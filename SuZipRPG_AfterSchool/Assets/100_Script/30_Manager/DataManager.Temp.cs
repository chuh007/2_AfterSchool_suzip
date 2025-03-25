#if UNITY_EDITOR
using ClassDefine;
using System.Collections.Generic;
using UnityEngine;

public partial class DataManager : MonoBehaviour
{
    public List<StudentInfo> TempStudentDataList = new List<StudentInfo>();
    public List<int> TempOwnStudentIdList = new List<int>();

    /// <summary>
    /// int => StudentID , List<StudentLevelStatusInfo> => Level Data
    /// </summary>
    public Dictionary<int, List<StudentLevelStatusInfo>> StudentLevelStatusDictionary = new Dictionary<int, List<StudentLevelStatusInfo>>();

    private void Start()
    {
        List<StudentLevelStatusInfo> tempStudentLevelStatusList = new List<StudentLevelStatusInfo>();
        
        // 임시로, 레벨 1당 모든 스텟과 경험치 요구량이 1씩 증가한다고 가정
        for (int i = 0; i < 5; i++)
        {

            StudentLevelStatusInfo tempStudentLevelData = new StudentLevelStatusInfo();

            tempStudentLevelData.Level = 1 + i;
            tempStudentLevelData.Exp = 100 + i;

            tempStudentLevelData.MaxHP = 10 + i;
            tempStudentLevelData.AttackPower = 11 + i;
            tempStudentLevelData.Defense = 12 + i;
            tempStudentLevelData.HealAmount = 13 + i;

            tempStudentLevelStatusList.Add(tempStudentLevelData);
        }

        StudentLevelStatusDictionary.Add(0, tempStudentLevelStatusList);
    }
}
#endif