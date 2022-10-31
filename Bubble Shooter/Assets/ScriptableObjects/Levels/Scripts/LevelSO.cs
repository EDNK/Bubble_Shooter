using System;
using System.Collections.Generic;
using Code.Bubble;
using ScriptableObjects.Configs;
using ScriptableObjects.Levels;
using ScriptableObjects.SequencePatterns;
using UnityEngine;

namespace ScriptableObjects.BubbleInfo
{
    [CreateAssetMenu(menuName = "Create LevelSO", fileName = "LevelSO", order = 0)]
    [Serializable]
    public class LevelSO : ScriptableObject
    {
        public GameConfig GameConfig;
        public BubbleSequence ShootSequence;
        public List<BubblesLayerData> Field = new List<BubblesLayerData>();

        private void OnValidate()
        {
            var layerType = LayerType.Full;
            for (var i = 0; i < Field.Count; i++)
            {
                if (NotCorrectLengthOfLayer(i, layerType))
                {
                    var newList = EditedList(layerType, i);
                    Field[i].Bubbles = newList;
                }

                Field[i].LayerType = layerType;
                layerType = layerType == LayerType.Full ? LayerType.NotFull : LayerType.Full;
            }
        }

        private List<BubbleData> EditedList(LayerType layerType, int i)
        {
            var newList = new List<BubbleData>();
            var expectedLength = ExpectedLength(layerType);
            for (var j = 0; j < expectedLength; j++)
            {
                if (Field[i].Bubbles.Count > j)
                {
                    newList.Add(Field[i].Bubbles[j]);
                    continue;
                }

                newList.Add(new BubbleData());
            }

            return newList;
        }

        private bool NotCorrectLengthOfLayer(int i, LayerType layerType)
        {
            return Field[i].Bubbles.Count != ExpectedLength(layerType);
        }

        private int ExpectedLength(LayerType layerType)
        {
            if (layerType == LayerType.Full)
            {
                return GameConfig.LayerLength;
            }

            return GameConfig.LayerLength - 1;
        }
    }
}