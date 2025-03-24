using TMPro;
using UnityEngine;

namespace _100_Scripts._20_UI
{
    public class TextView : MonoBehaviour, IUI
    {
        private TextMeshProUGUI mText;

        public void Initialize()
        {
            mText = GetComponent<TextMeshProUGUI>();
            
            if(mText != null) return;

            mText = GetComponentInChildren<TextMeshProUGUI>();
            if (mText == null)
            {
                Debug.Log("Text를 찾을 수 없습니다");
            }
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
}
