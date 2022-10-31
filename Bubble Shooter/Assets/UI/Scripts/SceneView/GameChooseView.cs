using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts.SceneView
{
    public class GameChooseView : UIView
    {
        [SerializeField] private Button _randomLevels;
        [SerializeField] private Button _presettedLevels;

        public Action RandomLevelsClick;
        public Action PresettedLevelsClick;

        protected override void InitializeView()
        {
            _randomLevels.onClick.AddListener(() => RandomLevelsClick?.Invoke());
            _presettedLevels.onClick.AddListener(() => PresettedLevelsClick?.Invoke());

            gameObject.SetActive(false);
        }

        public override void ShowView()
        {
            gameObject.SetActive(true);
        }

        public override void HideView()
        {
            gameObject.SetActive(false);
        }
    }
}