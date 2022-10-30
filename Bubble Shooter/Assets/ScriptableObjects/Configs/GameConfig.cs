using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjects.Configs
{
    [CreateAssetMenu(menuName = "GameConfig", fileName = "MainConfig")]
    public class GameConfig : ScriptableObject
    {
        [Tooltip("Максимальная горизонтальная длина слоя шаров")]
        [SerializeField]
        private int layerLength;

        public int LayerLength
        {
            get => layerLength;
            protected set { }
        }
    }
}