using UnityEngine;
using System.Collections.Generic;

public class DeckController : MonoBehaviour, IUI
{
    public ButtonController CloseButton;
    
    public ButtonController[] SkillUpButtonArray = new ButtonController[5];

    public void Initialize()
    {
        CloseButton.Initialize();
        CloseButton.SetButtonAction(() =>
        {
            Close();
        });

        for (int i = 0; i < SkillUpButtonArray.Length; i++)
        {
            SkillUpButtonArray[i].Initialize();
            SkillUpButtonArray[i].SetButtonAction(() =>
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
