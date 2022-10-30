using System;
using UI.Scripts.SceneView;
using UnityEngine;
using UnityEngine.UI;

public class MainView : UIView
{
    [SerializeField] private Button _playButton;
    public Action PlayClick;
    protected override void InitializeView()
    {
        _playButton.onClick.AddListener(() => PlayClick?.Invoke());
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
