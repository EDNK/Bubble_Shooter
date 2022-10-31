using ScriptableObjects.BubbleInfo;
using UI.Scripts.SceneView;
using UI.Scripts.ScreenManager;
using UnityEngine;

namespace UI.Scripts.ViewController
{
    public class GameChooseViewController : ViewScreenController
    {
        private const string PathToLevels = "Levels";
        private readonly GameChooseView _view;
        private readonly IScreenManager _screenManager;

        public GameChooseViewController(GameChooseView view, IScreenManager screenManager)
        {
            _view = view;
            _screenManager = screenManager;
        }

        public override void ShowView()
        {
            _view.RandomLevelsClick += RandomLevelsClick;
            _view.PreparedLevelsClick += PreparedLevelsClick;
            _view.LevelSelected += StartNewLevel;
            _view.ShowView();
        }

        private void PreparedLevelsClick()
        {
            var levels = Resources.LoadAll<LevelSO>(PathToLevels);
            _view.ShowLevelsList(levels);
        }

        private void RandomLevelsClick()
        {
            //TODO PASS TO GAMEVIEWCONTROLLER INTERFACES FOR RANDOMLEVEL
        }
        
        private void StartNewLevel(LevelSO level)
        {
            //TODO PASS TO GAMEVIEWCONTROLLER INTERFACES FOR LEVEL    
        }

        public override void HideView()
        {
            _view.HideView();
        }
    }
}