using Code.Bubble;

namespace Code.GameModel
{
    public class GameModel
    {
        private BubbleField _field;
        private IBubbleMagazine _magazine;

        public GameModel(BubbleField field, IBubbleMagazine magazine)
        {
            _field = field;
            _magazine = magazine;
        }
    }
}