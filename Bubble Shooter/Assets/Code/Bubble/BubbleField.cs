using System.Collections.Generic;
using System.Linq;

namespace Code.Bubble
{
    public class BubbleField
    {
        private readonly List<BubblesLayer> _bubbleField = new List<BubblesLayer>(10);

        public bool TryAddLayer(BubblesLayer newLayer)
        {
            if (_bubbleField.Last().LayerType == newLayer.LayerType)
            {
                return false;
            }

            _bubbleField.Add(newLayer);
            return true;
        }
    }
}
