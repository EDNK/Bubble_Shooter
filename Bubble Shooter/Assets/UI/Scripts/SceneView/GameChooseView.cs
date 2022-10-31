using System;
using ScriptableObjects.BubbleInfo;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts.SceneView
{
    public class GameChooseView : UIView
    {
        [SerializeField] private Button _presettedLevels;
        [SerializeField] private Button _randomLevels;
        [SerializeField] private LevelsListWidget _levelsListWidget;

        public Action RandomLevelsClick;
        public Action PreparedLevelsClick;
        public Action<LevelSO> LevelSelected;

        protected override void InitializeView()
        {
            _randomLevels.onClick.AddListener(() => RandomLevelsClick?.Invoke());
            _presettedLevels.onClick.AddListener(() => PreparedLevelsClick?.Invoke());

            gameObject.SetActive(false);
        }

        public void ShowLevelsList(LevelSO[] levels)
        {
            _levelsListWidget.ShowWidget(true);
            for (var i = 0; i < levels.Length; i++)
            {
                var levelWidget = Instantiate(_levelsListWidget.WidgetPrefab, _levelsListWidget.WidgetParent);
                levelWidget.SetupWidget((i+1).ToString());
                var i1 = i;
                levelWidget.OnLevelClick += () => { StartLevel(levels[i1]); };
            }
        }

        private void StartLevel(LevelSO level)
        {
            LevelSelected?.Invoke(level);
        }

        public override void ShowView()
        {
            gameObject.SetActive(true);
            _levelsListWidget.ShowWidget(false);
        }

        public override void HideView()
        {
            _levelsListWidget.ShowWidget(false);
            _levelsListWidget.DestroyLevelWidgets();
            gameObject.SetActive(false);
        }
    }
}