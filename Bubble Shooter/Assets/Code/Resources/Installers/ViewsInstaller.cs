using UI.Scripts.SceneView;
using UI.Scripts.ScreenManager;
using UI.Scripts.ViewController;
using UnityEngine;
using Zenject;

namespace Code.Resources.Installers
{
    public class ViewsInstaller : MonoInstaller, IInitializable
    {
        [SerializeField] private MainView _mainView;
        [SerializeField] private GameChooseView _gameChooseView;
        [SerializeField] private GameView _gameView;
        [SerializeField] private PauseView _pauseView;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo(GetType()).FromInstance(this);

            InstallViews();
            InstallViewControllers();

            Container.BindInterfacesTo<ScreenManager>().AsSingle();
        }

        private void InstallViewControllers()
        {
            Container.BindInterfacesAndSelfTo<MainViewController>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameViewController>().AsSingle();
            Container.BindInterfacesAndSelfTo<PauseViewController>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameChooseViewController>().AsSingle();
        }

        private void InstallViews()
        {
            Container.BindInterfacesAndSelfTo<MainView>().FromInstance(_mainView);
            Container.BindInterfacesAndSelfTo<GameView>().FromInstance(_gameView);
            Container.BindInterfacesAndSelfTo<PauseView>().FromInstance(_pauseView);
            Container.BindInterfacesAndSelfTo<GameChooseView>().FromInstance(_gameChooseView);
        }

        public void Initialize()
        {
            Container.Resolve<IScreenManager>().Resolve(Container);
        }
    }
}