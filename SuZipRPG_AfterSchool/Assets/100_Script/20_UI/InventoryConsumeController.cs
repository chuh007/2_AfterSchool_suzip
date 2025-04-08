using _100_Script._40_Utils;
using ClassDefine;
using UnityEngine;

namespace _100_Script._20_UI
{
    public class InventoryConsumeController : MonoBehaviour, IUI
    {
        
        public ButtonController[] ButtonControllerArray = new ButtonController[2];
        public TextView[] TextViewArray = new TextView[9];
        
        public void Initialize()
        {
            Close();

            foreach (var button in ButtonControllerArray)
            {
                button.Initialize();
            }
            
            ButtonControllerArray[0].SetButtonAction(() =>
            {
                Log.Message("",LogCategory.InventoryConsume);
            });
        }

        public void Open()
        {
            gameObject.SetActive(true);
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
            
            
            TextViewArray[1].SetText(tempTargetItem.Description);
        }
    }
}