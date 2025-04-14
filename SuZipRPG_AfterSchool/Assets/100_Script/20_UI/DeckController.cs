using UnityEngine;
using System.Collections.Generic;
using ClassDefine;

public class DeckController : MonoBehaviour, IUI
{
    public ButtonController CloseButton;
    public ButtonController[] SkillUpButtonArray = new ButtonController[5];

    public TextView[] TextViewArray = new TextView[9];

    public LevelUpController LevelUpController;
    public EquipUpController EquipUpController;

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

        LevelUpController = transform.GetComponentInChildren<LevelUpController>();
        LevelUpController.Initialize();

        EquipUpController.Initialize();

        Open();
        Close();
    }

    public void Open()
    {
        gameObject.SetActive(true);
        SetStudentDataText();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    private void SetStudentDataText()
    {
        StudentCharacter currentStudent = Manager.Data.OwnStudentInfoList[0];

        TextViewArray[0].SetText(currentStudent.GetTotalStatus(EnumDefine.AbilityType.MaxHP));
        TextViewArray[1].SetText(currentStudent.GetTotalStatus(EnumDefine.AbilityType.AttackPower));
        TextViewArray[2].SetText(currentStudent.GetTotalStatus(EnumDefine.AbilityType.Defense));
        TextViewArray[3].SetText(currentStudent.GetTotalStatus(EnumDefine.AbilityType.HealAmount));
        TextViewArray[4].SetText(currentStudent.Name);
        TextViewArray[5].SetText("");
        TextViewArray[6].SetText("");
        TextViewArray[7].SetText("");
        TextViewArray[8].SetText("");
    }
}
