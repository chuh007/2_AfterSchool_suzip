#if UNITY_EDITOR
using ClassDefine;
using EnumDefine;
using System.Collections.Generic;
using UnityEngine;

public partial class DataManager : MonoBehaviour
{
    public List<StudentCharacter> TempStudentDataList = new List<StudentCharacter>();
    public List<int> TempOwnStudentIdList = new List<int>();

    /// <summary>
    /// int => StudentID , List<StudentLevelStatusInfo> => Level Data
    /// </summary>
    public Dictionary<int, List<StudentLevelStatusInfo>> StudentLevelStatusDictionary = new Dictionary<int, List<StudentLevelStatusInfo>>();

    private void Start()
    {


        return;

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

    [SerializeField] public List<ConsumeInfo> ConsumeItemList = new List<ConsumeInfo>()
{
    new ConsumeInfo
    {
        ID = 1001,
        ConsumeType = ConsumeType.Unusable,
        Name = "학생 모집 티켓",
        Description = "학생 모집에 사용할 수 있는 티켓입니다.",
        Count = 10,
        Grade = ItemGrade.Common
    },

    new ConsumeInfo
    {
        ID = 1002,
        ConsumeType = ConsumeType.Select,
        Name = "선택형 학생 모집 티켓",
        Description = "특정 학교의 학생을 모집할 수 있는 티켓입니다.",
        Count = 1,
        Grade = ItemGrade.Rare
    },

    new ConsumeInfo
    {
        ID = 1003,
        ConsumeType = ConsumeType.Random,
        Name = "비밀 기술 노트",
        Description = "랜덤한 학생의 스킬을 강화할 수 있는 노트입니다.",
        Count = 3,
        Grade = ItemGrade.Epic
    },

    new ConsumeInfo
    {
        ID = 1004,
        ConsumeType = ConsumeType.Unusable,
        Name = "정화된 샤이니",
        Description = "학생의 레벨을 즉시 올려주는 희귀한 재료입니다.",
        Count = 2,
        Grade = ItemGrade.Legendary
    },

    new ConsumeInfo
    {
        ID = 1005,
        ConsumeType = ConsumeType.Select,
        Name = "특수 작전 지령서",
        Description = "특정 난이도의 특수 작전에 참여할 수 있는 지령서입니다.",
        Count = 5,
        Grade = ItemGrade.Rare
    },

    new ConsumeInfo
    {
        ID = 1006,
        ConsumeType = ConsumeType.Random,
        Name = "미식 클럽의 도시락",
        Description = "랜덤 버프를 제공하는 도시락입니다.",
        Count = 3,
        Grade = ItemGrade.Common
    },

    new ConsumeInfo
    {
        ID = 1007,
        ConsumeType = ConsumeType.Unusable,
        Name = "키보토스 연합 코인",
        Description = "상점에서 특별한 아이템과 교환할 수 있는 코인입니다.",
        Count = 500,
        Grade = ItemGrade.Epic
    },

    new ConsumeInfo
    {
        ID = 1008,
        ConsumeType = ConsumeType.Select,
        Name = "엘리트 작전 보고서",
        Description = "원하는 학생의 경험치를 대폭 상승시키는 보고서입니다.",
        Count = 1,
        Grade = ItemGrade.Legendary
    },

    new ConsumeInfo
    {
        ID = 1009,
        ConsumeType = ConsumeType.Random,
        Name = "총학생회 긴급 패키지",
        Description = "다양한 물자가 랜덤으로 포함된 긴급 지원 패키지입니다.",
        Count = 2,
        Grade = ItemGrade.Epic
    },

    new ConsumeInfo
    {
        ID = 1010,
        ConsumeType = ConsumeType.Unusable,
        Name = "AP 회복 음료",
        Description = "행동력을 120만큼 회복시켜주는 음료입니다.",
        Count = 15,
        Grade = ItemGrade.Common
    }
};
}
#endif