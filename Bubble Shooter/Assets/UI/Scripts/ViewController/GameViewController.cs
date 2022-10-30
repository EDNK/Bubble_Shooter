using System;
using UI.Scripts.SceneView;

namespace UI.Scripts.ViewController
{
    public class GameViewController : ViewScreenController
    {
        private readonly GameView _gameView;

        public GameViewController(GameView gameView)
        {
            _gameView = gameView;
        }
        
        public override void ShowView()
        {
            _gameView.ShowView();
        }

        public override void HideView()
        {
            _gameView.HideView();
        }
    }
}