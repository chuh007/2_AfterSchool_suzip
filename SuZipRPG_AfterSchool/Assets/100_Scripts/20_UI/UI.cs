using UnityEngine;

namespace _100_Scripts._20_UI
{
    public class UI : MonoBehaviour
    {
        private void Start()
        {
            SetDeckController();
            SetSkillUpController();
        }
        /*
         * 1. get과 set을 다른 접근 권한으로 사용하기 위해
         * 2. 중단점 찍고 확인하기 좋다.
         * 3. 객체지향 -> 캡슐화, 
         */
        public static DeckController DeckController {get; private set;}

        
        private void SetDeckController()
        {
            DeckController = GetComponentInChildren<DeckController>();
            DeckController.Initialize();
        }
        
        public static SkillUpController SkillUpController;

        private void SetSkillUpController()
        {
            SkillUpController = GetComponentInChildren<SkillUpController>();
            Debug.Assert(SkillUpController != null,"SkillUpController is null");
            SkillUpController?.Initialize();
        }
        
    }
}
