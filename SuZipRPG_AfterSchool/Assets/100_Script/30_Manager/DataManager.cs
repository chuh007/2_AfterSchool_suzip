using ClassDefine;
using System.Collections.Generic;
using UnityEngine;

public partial class DataManager : MonoBehaviour
{
    public int Gold;

    public int Gem;

    public List<StudentCharacter> AllCharacterInfoList = new List<StudentCharacter>();

    public List<StudentCharacter> OwnStudentInfoList = new List<StudentCharacter>();

    public void Initialize()
    {
        SetStudentData();
    }

    private void SetStudentData()
    {
        StudentCharacter tempStudent = new StudentCharacter();
        tempStudent.Id = 0;
        tempStudent.Name = "Aris";
        tempStudent.Level = 1;
        tempStudent.Exp = 0;

        tempStudent.SetAbility(EnumDefine.AbilityType.MaxHP, EnumDefine.AbilityReason.Level, 10);
        tempStudent.SetAbility(EnumDefine.AbilityType.AttackPower, EnumDefine.AbilityReason.Level, 10);
        tempStudent.SetAbility(EnumDefine.AbilityType.Defense, EnumDefine.AbilityReason.Level, 10);
        tempStudent.SetAbility(EnumDefine.AbilityType.HealAmount, EnumDefine.AbilityReason.Level, 10);

        TempStudentDataList.Add(tempStudent);

        foreach (var StudentData in TempStudentDataList)
        {
            AllCharacterInfoList.Add(StudentData);

            if(TempOwnStudentIdList.Contains(StudentData.Id) == true)
            {
                OwnStudentInfoList.Add(StudentData);
            }
        } 
    }
}
