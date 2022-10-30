using UI.Scripts.SceneView;
using UI.Scripts.ScreenManager;

namespace UI.Scripts.ViewController
{
    public class MainViewController : ViewScreenController
    {
        private readonly MainView _view;
        private readonly IScreenManager _screenManager;

        public MainViewController(MainView view, IScreenManager screenManager)
        {
            _view = view;
            _screenManager = screenManager;
        }

        public override void ShowView()
        {
            _view.PlayClick += PlayClick;
            _view.ShowView();
        }

        public override void HideView()
        {
            _view.PlayClick -= PlayClick;
            _view.HideView();
        }

        private void PlayClick()
        {
            _screenManager.ShowView(typeof(GameViewController));
            HideView();
        }
    }
}