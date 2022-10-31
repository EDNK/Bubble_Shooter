using Code.Bubble;

namespace Code.GameModel
{
    public interface ILevelLoader
    {
        GameModel CreateGameModel();
        BubbleField CreateField();
    }
}