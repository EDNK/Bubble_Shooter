using System;
using Code.Bubble;

namespace ScriptableObjects.Levels
{
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