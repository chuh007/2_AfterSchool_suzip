using System.Collections.Generic;
using UnityEngine;

namespace _100_Scripts._20_UI
{
    public class DeckController : MonoBehaviour, IUI
    {
        public ButtonController CloseButton;

        public ButtonController[] skillUpButtonArr = new ButtonController[5];
        
        public void Initialize()
        {
            CloseButton.Initialize();
            CloseButton.SetButtonAction(() =>
            {
                gameObject.SetActive(false);
            });

            for (int i = 0; i < skillUpButtonArr.Length; i++)
            {
                int tempindex = i;
                skillUpButtonArr[tempindex].Initialize();
                skillUpButtonArr[tempindex].SetButtonAction(() =>
                {
                    UI.SkillUpController.Open();
                });
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