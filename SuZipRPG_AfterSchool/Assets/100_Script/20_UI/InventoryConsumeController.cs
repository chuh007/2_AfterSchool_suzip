using ClassDefine;
using UnityEngine;

public class InventoryConsumeController : MonoBehaviour, IUI
{
    public ButtonController[] ButtonControllerArray = new ButtonController[2];
    public TextView[] TextViewArray = new TextView[3];

    public void Initialize()
    {

        foreach (var button in ButtonControllerArray)
        {
            button.Initialize();
        }

        ButtonControllerArray[0].SetButtonAction(() =>
        {
            Log.Message("획득 장소 UI 출력", LogCategory.InventoryConsume);
        });
        ButtonControllerArray[1].SetButtonAction(() =>
        {
            Log.Message("열기 버튼 출력", LogCategory.InventoryConsume);
        });

        Open();
    }

    public void Open()
    {
        gameObject.SetActive(true);

        SetItemConsumeText();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void SetItemConsumeText()
    {
        ConsumeInfo tempTargetItem = Manager.Data.ConsumeItemList[0];

        TextViewArray[0].SetText(tempTargetItem.Name);
        TextViewArray[1].SetText(tempTargetItem.Description);

        string countText = $"보유 수량\nx{tempTargetItem.Count}";
        TextViewArray[2].SetText(countText);
    }
}
