using System.Collections.Generic;

namespace Code.Bubble
{
    public abstract class BubblesLayer
    {
        private List<Bubble> _bubbleList;

        public LayerType LayerType { get; }

        protected BubblesLayer(List<Bubble> bubbleList, LayerType layerType)
        {
            _bubbleList = bubbleList;
            LayerType = layerType;
        }
    }
}