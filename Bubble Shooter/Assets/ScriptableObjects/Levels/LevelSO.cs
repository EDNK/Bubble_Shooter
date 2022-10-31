using System;
using System.Collections.Generic;
using System.Linq;
using Code.Bubble;
using ScriptableObjects.Configs;
using UnityEngine;

namespace ScriptableObjects.BubbleInfo
{
    [CreateAssetMenu(menuName = "Create LevelSO", fileName = "LevelSO", order = 0)]
    [Serializable]
    public class LevelSO : ScriptableObject
    {
        public GameConfig _gameConfig;
        public List<BubblesLayerData> _field = new List<BubblesLayerData>();

        private void OnValidate()
        {
            var layerType = LayerType.Full;
            for (var i = 0; i < _field.Count; i++)
            {
                if (NotCorrectLengthOfLayer(i, layerType))
                {
                    var newList = EditedList(layerType, i);
                    _field[i].Bubbles = newList;
                }

                _field[i].LayerType = layerType;
                layerType = layerType == LayerType.Full ? LayerType.NotFull : LayerType.Full;
            }
        }

        private List<BubbleData> EditedList(LayerType layerType, int i)
        {
            var newList = new List<BubbleData>();
            var expectedLength = ExpectedLength(layerType);
            for (var j = 0; j < expectedLength; j++)
            {
                if (_field[i].Bubbles.Count > j)
                {
                    newList.Add(_field[i].Bubbles[j]);
                    continue;
                }

                newList.Add(new BubbleData());
            }

            return newList;
        }

        private bool NotCorrectLengthOfLayer(int i, LayerType layerType)
        {
            return _field[i].Bubbles.Count != ExpectedLength(layerType);
        }

        private int ExpectedLength(LayerType layerType)
        {
            if (layerType == LayerType.Full)
            {
                return _gameConfig.LayerLength;
            }

            return _gameConfig.LayerLength - 1;
        }

        [Serializable]
        public class BubblesLayerData
        {
            public List<BubbleData> Bubbles;
            public LayerType LayerType;

            public BubblesLayerData(List<BubbleData> list, LayerType layerType)
            {
                Bubbles = list;
                LayerType = layerType;
            }
        }

        [Serializable]
        public class BubbleData
        {
            public BubbleColor BubbleColor;

            public BubbleData()
            {
                BubbleColor = BubbleColor.Empty;
            }
        }
    }
}