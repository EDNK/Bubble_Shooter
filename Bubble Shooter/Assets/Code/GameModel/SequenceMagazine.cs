using System;
using System.Collections.Generic;
using ScriptableObjects.SequencePatterns;
using UnityEngine;

namespace Code.GameModel
{
    public class SequenceMagazine : IBubbleMagazine
    {
        private List<Bubble.Bubble> _sequence = new List<Bubble.Bubble>();

        private int CurrentBubbleIndex
        {
            get => CurrentBubbleIndex;
            set => CurrentBubbleIndex = Mathf.Clamp(value, 0, _sequence.Count - 1);
        }

        public Bubble.Bubble CurrentBubble()
        {
            return _sequence[CurrentBubbleIndex];
        }

        public Bubble.Bubble NextBubble()
        {
            return CurrentBubbleIndex < _sequence.Count ? _sequence[CurrentBubbleIndex] : _sequence[0];
        }

        public void SwapBubbles()
        {
            var currentBubble = CurrentBubble();
            var nextBubble = NextBubble();
            (currentBubble, nextBubble) = (nextBubble, currentBubble);
        }

        public SequenceMagazine(BubbleSequence sequence)
        {
            CurrentBubbleIndex = 0;
            foreach (var bubbleData in sequence.Sequence)
            {
                _sequence.Add(new Bubble.Bubble(bubbleData.BubbleColor, Vector2.zero));
            }
        }
    }
}