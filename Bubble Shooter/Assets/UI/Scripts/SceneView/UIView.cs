using UI.Scripts.ScreenManager;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts.SceneView
{
    [RequireComponent(typeof(RectTransform)), RequireComponent(typeof(Canvas)),
     RequireComponent(typeof(GraphicRaycaster)),
     RequireComponent(typeof(CanvasGroup))]
    public abstract class UIView : MonoBehaviour
    {
        private IScreenManager _screenManager;

        public void Construct(IScreenManager screenManager)
        {
            _screenManager = screenManager;
            Initialize();
        }

        private void Initialize()
        {
            _screenManager.RegisterView(this);
            InitializeView();
            gameObject.SetActive(false);
        }

        protected abstract void InitializeView();
    }
}