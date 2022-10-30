using System;
using UI.Scripts.SceneView;
using UI.Scripts.ViewController;

namespace UI.Scripts.ScreenManager
{
    public interface IScreenManager
    {
        void RegisterView(UIView view);
        void RegisterController(ViewScreenController controller);
        void UnregisterView(UIView view);
        void UnregisterController(ViewScreenController controller);
        void ShowView(Type controllerType);
        void HideView(Type controllerType);
    }
}