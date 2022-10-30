using UI.Scripts.ScreenManager;
using UI.Scripts.ViewController;
using UnityEngine;
using Zenject;

namespace Code.Resources.Installers
{
    public class ViewsInstaller : MonoInstaller
    {
        [SerializeField] private MainView _mainView;
        [SerializeField] private GameView _gameView;
        [SerializeField] private PauseView _pauseView;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainView>().FromInstance(_mainView);
            Container.BindInterfacesAndSelfTo<MainViewController>().AsSingle();

            Container.BindInterfacesAndSelfTo<GameView>().FromInstance(_gameView);
            Container.BindInterfacesAndSelfTo<GameViewController>().AsSingle();

            Container.BindInterfacesAndSelfTo<PauseView>().FromInstance(_pauseView);
            Container.BindInterfacesAndSelfTo<PauseViewController>().AsSingle();

            Container.BindInterfacesTo<ScreenManager>().AsSingle();
        }
    }
}