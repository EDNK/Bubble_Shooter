using System;
using Code.Bubble;
using ScriptableObjects.Configs;

namespace Code.GameModel
{
    public class RandomLevelLoader : ILevelLoader
    {
        private GameConfig _gameConfig;
        public RandomLevelLoader(GameConfig gameConfig)
        {
            _gameConfig = gameConfig;
        }
        
        public GameModel CreateGameModel()
        {
            var field = CreateField();
            var magazine = new RandomMagazine();
            return new GameModel(field, magazine);
        }

        public BubbleField CreateField()
        {
            throw new NotImplementedException();
        }
    }
}