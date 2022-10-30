using System;
using System.Collections.Generic;
using System.Linq;
using UI.Scripts.SceneView;
using UI.Scripts.ViewController;
using UnityEngine;
using Zenject;

namespace UI.Scripts.ScreenManager
{
    public class ScreenManager : IScreenManager
    {
        private readonly List<IViewController> _controllers = new List<IViewController>(6);
        private readonly List<UIView> _views = new List<UIView>(6);

        public void Resolve(DiContainer container)
        {
            foreach (var viewController in container.ResolveAll<IViewController>())
            {
                RegisterController(viewController);
            }
        }

        public void RegisterView(UIView view)
        {
            if (!_views.Contains(view))
            {
                _views.Add(view);
            }
        }

        public void RegisterController(IViewController controller)
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

        public void UnregisterController(IViewController controller)
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

        private IViewController GetController(Type controllerType)
        {
            return _controllers.First(controllerType.IsInstanceOfType);
        }
    }
}