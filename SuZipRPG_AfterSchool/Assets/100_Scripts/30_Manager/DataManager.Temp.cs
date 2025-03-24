#if UNITY_EDITOR
using ClassDefine;
using System.Collections.Generic;
using UnityEngine;

public partial class DataManager
{
    public List<StudentInfo> TempStudentDataList = new List<StudentInfo>();
    public List<int> TempOwnStudentIdList = new List<int>();
}
#endif