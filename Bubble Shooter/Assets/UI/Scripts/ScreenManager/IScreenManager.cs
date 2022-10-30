using System;
using UI.Scripts.SceneView;
using UI.Scripts.ViewController;
using Zenject;

namespace UI.Scripts.ScreenManager
{
    public interface IScreenManager
    {
        void Resolve(DiContainer container);
        void RegisterView(UIView view);
        void RegisterController(IViewController controller);
        void UnregisterView(UIView view);
        void UnregisterController(IViewController controller);
        void ShowView(Type controllerType);
        void HideView(Type controllerType);
    }
}