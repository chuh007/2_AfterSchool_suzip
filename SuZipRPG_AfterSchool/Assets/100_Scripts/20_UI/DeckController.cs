using System;
using System.Collections.Generic;
using _100_Scripts._30_Manager;
using ClassDefine;
using UnityEngine;

namespace _100_Scripts._20_UI
{
    public class DeckController : MonoBehaviour, IUI
    {
        public ButtonController CloseButton;

        public ButtonController[] skillUpButtonArr = new ButtonController[5];
        
        public TextView[] TextViewArray = new TextView[9];
        
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
            Open();
        }
        
        public void Open()
        {
            gameObject.SetActive(true);
            foreach (TextView txt in TextViewArray) txt.Initialize();
            SetStudentDataText();
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }

        private void SetStudentDataText()
        {
            StudentInfo currentStudent = Manager.Data.OwnStudentInfoList[0];
            
            TextViewArray[0].SetText(currentStudent.Hp);
            TextViewArray[1].SetText(currentStudent.AttackPower);
            TextViewArray[2].SetText(currentStudent.Defense);
            TextViewArray[3].SetText(currentStudent.HealAmount);
            TextViewArray[4].SetText(currentStudent.Name);
            TextViewArray[5].SetText(currentStudent.CombatRole.ToString());
            TextViewArray[6].SetText(currentStudent.CombatPosition.ToString());
            TextViewArray[7].SetText(currentStudent.AttackType.ToString());
            TextViewArray[8].SetText(currentStudent.ArmorType.ToString());
        }
    }
}