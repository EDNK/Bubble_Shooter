using UI.Scripts.SceneView;

namespace UI.Scripts.ScreenManager
{
    public interface IScreenManager
    {
        void RegisterView(UIView view);
        void UnregisterView(UIView view);
    }
}
