using Code.Bubble;
using ScriptableObjects.BubbleInfo;

namespace Code.GameModel
{
    public class LevelSOLoader : ILevelLoader
    {
        private LevelSO _level;
        public LevelSOLoader(LevelSO level)
        {
            _level = level;
        }
        
        public GameModel CreateGameModel()
        {
            var field = CreateField();
            var magazine = new SequenceMagazine(_level.ShootSequence);
            return new GameModel(field, magazine);
        }

        public BubbleField CreateField()
        {
            throw new System.NotImplementedException();
        }
    }
}