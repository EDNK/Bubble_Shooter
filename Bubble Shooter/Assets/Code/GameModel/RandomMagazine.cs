using System;
using Code.Bubble;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code.GameModel
{
    public class RandomMagazine : IBubbleMagazine
    {
        private Bubble.Bubble _currentBubble;
        private Bubble.Bubble _nextBubble;

        public RandomMagazine()
        {
            _currentBubble = RandomBubble();
            _nextBubble = RandomBubble();
        }

        private Bubble.Bubble RandomBubble()
        {
            return new Bubble.Bubble((BubbleColor)Random.Range(1, BubbleColorsEnumLength()), Vector2.zero);
        }

        private static int BubbleColorsEnumLength()
        {
            return Enum.GetNames(typeof(BubbleColor)).Length;
        }

        public Bubble.Bubble CurrentBubble()
        {
            return _currentBubble;
        }

        public Bubble.Bubble NextBubble()
        {
            return _nextBubble;
        }

        public void SwapBubbles()
        {
            (_nextBubble, _currentBubble) = (_currentBubble, _nextBubble);
        }
    }
}