using UnityEngine;

public class LevelsListWidget : MonoBehaviour
{
    public LevelButtonWidget WidgetPrefab;
    public Transform WidgetParent;

    public void DestroyLevelWidgets()
    {
        for (var i = 0; i < WidgetParent.childCount; i++)
        {
            Destroy(WidgetParent.GetChild(i));
        }
    }

    public void ShowWidget(bool active)
    {
        gameObject.SetActive(active);
    }
}