using System;
using System.Collections.Generic;
using Code.Bubble;

namespace ScriptableObjects.Levels
{
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
}