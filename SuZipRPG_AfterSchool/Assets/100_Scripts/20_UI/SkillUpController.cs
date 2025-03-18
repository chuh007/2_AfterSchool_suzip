using UnityEngine;
using UnityEngine.UI;

namespace _100_Scripts._20_UI
{
    public class SkillUpController : MonoBehaviour, IUI
    {
        public ButtonController[] closeButtonArray = new ButtonController[2];
        
        public void Initialize()
        {
            Close();

            for (int i = 0; i < closeButtonArray.Length; i++)
            {
                closeButtonArray[i].Initialize();
                closeButtonArray[i].SetButtonAction(Close);
            }
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}