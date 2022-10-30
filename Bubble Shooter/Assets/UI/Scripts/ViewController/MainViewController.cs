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
            _view.Show();
        }

        public override void HideView()
        {
            _view.PlayClick -= PlayClick;
            _view.Hide();
        }
        
        private void PlayClick()
        {
            HideView();
            _screenManager.ShowView(typeof(GameView));
        }
    }
}