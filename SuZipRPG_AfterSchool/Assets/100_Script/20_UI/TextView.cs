using TMPro;
using UnityEngine;

public class TextView : MonoBehaviour, IUI
{
    [SerializeField] private TextMeshProUGUI mText;

    public void Initialize()
    {
        SetText(string.Empty);
    }

    public void Open()
    {

    }

    public void Close()
    {

    }

    public void SetText(string text)
    {
        mText.text = text;
    }

    public void SetText(int text)
    {
        SetText(text.ToString());
    }
}
