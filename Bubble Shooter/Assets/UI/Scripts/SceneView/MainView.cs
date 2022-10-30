using System;
using UI.Scripts.SceneView;
using UnityEngine;
using UnityEngine.UI;

public class MainView : UIView
{
    [SerializeField] private Button _playButton;
    public Action PlayClick;

    public override void ShowView()
    {
        gameObject.SetActive(true);
    }

    protected override void InitializeView()
    {
        _playButton.onClick.AddListener(() => PlayClick?.Invoke());
    }

    public override void HideView()
    {
        gameObject.SetActive(false);
    }
}