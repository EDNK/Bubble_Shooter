using System;
using UnityEngine;
using UnityEngine.UIElements;
using Object = System.Object;

namespace UI.Scripts.SceneView
{
    public class GameView : UIView
    {
        [SerializeField] private RectTransform _bubbleField;
        [SerializeField] private Transform _bubbleGun;

        private RectTransform _bubbleToShoot;
        private Vector2 _prevTouchPosition;

        public Action<Vector2> Shoot;
        
        protected override void InitializeView()
        {
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown((int)MouseButton.LeftMouse))
            {
                _prevTouchPosition = Camera.main.WorldToScreenPoint(Input.GetTouch(0).position);
            }

            if (Input.GetMouseButtonUp((int)MouseButton.LeftMouse))
            {
                Shoot?.Invoke((Vector2)_bubbleGun.position-_prevTouchPosition);
            }
        }

        public override void ShowView()
        {
            gameObject.SetActive(true);
        }

        public override void HideView()
        {
            gameObject.SetActive(false);
            DestroyBubbleViews();
        }

        private void DestroyBubbleViews()
        {
            for (var i = 0; i < _bubbleField.childCount; i++)
            {
                Destroy(_bubbleField.GetChild(i));
            }
        }

        public RectTransform GetBubble()
        {
            
        }
    }
}