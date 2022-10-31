using UI.Scripts.SceneView;
using UI.Scripts.ScreenManager;

namespace UI.Scripts.ViewController
{
    public class GameChooseViewController: ViewScreenController
    {
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
            _view.PresettedLevelsClick += PresettedLevelsClick;
            _view.ShowView();
        }

        private void PresettedLevelsClick()
        {
            HideView();
        }

        private void RandomLevelsClick()
        {
            HideView();
        }

        public override void HideView()
        {
            _view.HideView();
        }
    }
}