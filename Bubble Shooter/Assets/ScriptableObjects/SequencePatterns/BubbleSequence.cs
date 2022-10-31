using System;
using System.Collections.Generic;
using System.Linq;
using Code.Bubble;
using ScriptableObjects.Levels;
using UnityEngine;

namespace ScriptableObjects.SequencePatterns
{
    [CreateAssetMenu(menuName = "Create BubbleSequence", fileName = "BubbleSequence", order = 0)]
    public class BubbleSequence : ScriptableObject
    {
        public List<BubbleData> Sequence = new List<BubbleData>();

        private void OnValidate()
        {
            Sequence.ForEach(CheckForEmpty);
        }

        private void CheckForEmpty(BubbleData bubbleData)
        {
            if (bubbleData.BubbleColor == BubbleColor.Empty)
            {
                bubbleData.BubbleColor = BubbleColor.Blue;
            }
        }
    }
}