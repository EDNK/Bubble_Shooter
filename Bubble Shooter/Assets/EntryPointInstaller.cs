using UnityEngine;
using Zenject;

public class EntryPointInstaller : MonoInstaller
{
    [SerializeField] private EntryPoint _entryPoint;
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<EntryPoint>().FromInstance(_entryPoint);
    }
}
