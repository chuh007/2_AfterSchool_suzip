using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button TargetButton;
    public Image TargetButtonImage;

    public void Initialize()
    {
        TargetButton = GetComponent<Button>();
        TargetButtonImage = GetComponent<Image>();
    }

    public void SetButtonAction(UnityAction action)
    {
        TargetButton.onClick.RemoveAllListeners();
        TargetButton.onClick.AddListener(action);
    }
}
