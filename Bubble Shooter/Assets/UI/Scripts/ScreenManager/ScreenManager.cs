using System;
using System.Collections.Generic;
using System.Linq;
using UI.Scripts.SceneView;
using UI.Scripts.ViewController;
using UnityEngine;

namespace UI.Scripts.ScreenManager
{
    public class ScreenManager : IScreenManager
    {
        private readonly List<ViewScreenController> _controllers = new List<ViewScreenController>(6);
        private readonly List<UIView> _views = new List<UIView>(6);

        public void RegisterView(UIView view)
        {
            if (!_views.Contains(view))
            {
                _views.Add(view);
            }
        }

        public void RegisterController(ViewScreenController controller)
        {
            if (!_controllers.Contains(controller))
            {
                _controllers.Add(controller);
            }
        }

        public void UnregisterView(UIView view)
        {
            _views.Remove(view);
        }

        public void UnregisterController(ViewScreenController controller)
        {
            _controllers.Remove(controller);
        }

        public void ShowView(Type controllerType)
        {
            var controller = GetController(controllerType);
            if (controller == null)
            {
                Debug.LogError($"There is no view controller of type {controllerType}");
                return;
            }

            controller.ShowView();
        }

        private ViewScreenController GetController(Type controllerType)
        {
            return _controllers.First(controllerType.IsInstanceOfType);
        }

        public void HideView(Type controllerType)
        {
            var controller = GetController(controllerType);
            if (controller == null)
            {
                Debug.LogError($"There is no view controller of type {controllerType}");
                return;
            }
            
            controller.HideView();
        }
    }
}