using System;
using UI.Scripts.SceneView;
using UnityEngine;

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
            _gameView.Shoot += ShootNewBall;
        }

        private void ShootNewBall(Vector2 direction)
        {
            var go = _gameView.GetBubble();
        }

        public override void HideView()
        {
            _gameView.HideView();
        }
    }
}