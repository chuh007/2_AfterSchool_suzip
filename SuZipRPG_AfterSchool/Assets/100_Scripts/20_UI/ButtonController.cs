using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _100_Scripts._20_UI
{
    public class ButtonController : MonoBehaviour
    {
        public Button TargetButton;
        public Image TargetButtonImage;

        public void Initialize()
        {
            TargetButtonImage = GetComponent<Image>();
            TargetButton = TargetButtonImage.GetComponent<Button>();
        }        
        public void SetButtonAction(UnityAction action)
        {
            TargetButton.onClick.RemoveAllListeners();
            TargetButton.onClick.AddListener(action);
        }
    }
}
