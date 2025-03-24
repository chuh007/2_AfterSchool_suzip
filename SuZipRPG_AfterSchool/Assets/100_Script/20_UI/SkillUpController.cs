using UnityEngine;

public class SkillUpController : MonoBehaviour, IUI
{
    public ButtonController[] CloseButtonArray = new ButtonController[2];

    public void Initialize()
    {
        Close();

        for (int i = 0; i < CloseButtonArray.Length; i++)
        {
            CloseButtonArray[i].Initialize();
            CloseButtonArray[i].SetButtonAction(Close);
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
