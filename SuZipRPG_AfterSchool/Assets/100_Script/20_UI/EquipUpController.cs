using UnityEngine;
using EnumDefine;

public class EquipUpController : MonoBehaviour, IUI
{
    public StudentCharacter CurrentStudent;

    public ButtonController[] EquipButtonArray = new ButtonController[3];

    public void Initialize()
    {
        CurrentStudent = Manager.Data.OwnStudentInfoList[0];

        for (int i = 0; i < EquipButtonArray.Length; i++)
        {
            EquipButtonArray[i].Initialize();
        }

        EquipButtonArray[0].SetButtonAction(() =>
        {
            var currentHpStatus = CurrentStudent.GetTotalStatus(AbilityType.MaxHP);
            CurrentStudent.SetAbility(AbilityType.MaxHP, AbilityReason.Equip1, currentHpStatus + 10);
        });
        EquipButtonArray[1].SetButtonAction(() =>
        {
            var currentAttackPowerStatus = CurrentStudent.GetTotalStatus( AbilityType.AttackPower);
            CurrentStudent.SetAbility(AbilityType.AttackPower, AbilityReason.Equip2, currentAttackPowerStatus + 10);
        });
        EquipButtonArray[2].SetButtonAction(() =>
        {
            var currentDefenseStatus = CurrentStudent.GetTotalStatus( AbilityType.Defense);
            CurrentStudent.SetAbility(AbilityType.Defense, AbilityReason.Equip3, currentDefenseStatus + 10);
        });

        Close();
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
