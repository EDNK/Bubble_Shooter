namespace Code.GameModel
{
    public interface IBubbleMagazine
    {
        Bubble.Bubble CurrentBubble();
        Bubble.Bubble NextBubble();

        void SwapBubbles();
    }
}
