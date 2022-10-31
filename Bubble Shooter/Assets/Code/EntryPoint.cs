using System;
using UI.Scripts.ScreenManager;
using UI.Scripts.ViewController;
using UnityEngine;
using Zenject;

public class EntryPoint : MonoBehaviour
{
    private IScreenManager _screenManager;

    [Inject]
    public void Construct(IScreenManager screenManager)
    {
        _screenManager = screenManager;
    }

    public void Start()
    {
        _screenManager.ShowView(typeof(MainViewController));
    }
}