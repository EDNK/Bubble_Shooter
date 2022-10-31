using UnityEngine;

namespace Code.Bubble
{
    public class Bubble
    {
        private BubbleColor _color;
        private Vector2 _position;

        public Bubble(BubbleColor color, Vector2 position)
        {
            _color = color;
            _position = position;
        }
    }
}