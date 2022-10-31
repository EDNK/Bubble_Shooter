using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelButtonWidget : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _number;
    [SerializeField] private Button _button;

    public Action OnLevelClick;

    private void Start()
    {
        _button.onClick.AddListener(() => OnLevelClick?.Invoke());
    }

    public void SetupWidget(string number)
    {
        _number.text = number;
    }
}