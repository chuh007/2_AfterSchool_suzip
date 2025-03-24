using ClassDefine;
using System.Collections.Generic;
using UnityEngine;

public partial class DataManager : MonoBehaviour
{
    public List<StudentInfo> AllCharacterInfoList = new List<StudentInfo>();

    public List<StudentInfo> OwnStudentInfoList = new List<StudentInfo>();

    public void Initialize()
    {
        SetStudentData();
    }

    private void SetStudentData()
    {
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