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

        // �ӽ÷�, ���� 1�� ��� ���ݰ� ����ġ �䱸���� 1�� �����Ѵٰ� ����
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
        Name = "�л� ���� Ƽ��",
        Description = "�л� ������ ����� �� �ִ� Ƽ���Դϴ�.",
        Count = 10,
        Grade = ItemGrade.Common
    },

    new ConsumeInfo
    {
        ID = 1002,
        ConsumeType = ConsumeType.Select,
        Name = "������ �л� ���� Ƽ��",
        Description = "Ư�� �б��� �л��� ������ �� �ִ� Ƽ���Դϴ�.",
        Count = 1,
        Grade = ItemGrade.Rare
    },

    new ConsumeInfo
    {
        ID = 1003,
        ConsumeType = ConsumeType.Random,
        Name = "��� ��� ��Ʈ",
        Description = "������ �л��� ��ų�� ��ȭ�� �� �ִ� ��Ʈ�Դϴ�.",
        Count = 3,
        Grade = ItemGrade.Epic
    },

    new ConsumeInfo
    {
        ID = 1004,
        ConsumeType = ConsumeType.Unusable,
        Name = "��ȭ�� ���̴�",
        Description = "�л��� ������ ��� �÷��ִ� ����� ����Դϴ�.",
        Count = 2,
        Grade = ItemGrade.Legendary
    },

    new ConsumeInfo
    {
        ID = 1005,
        ConsumeType = ConsumeType.Select,
        Name = "Ư�� ���� ���ɼ�",
        Description = "Ư�� ���̵��� Ư�� ������ ������ �� �ִ� ���ɼ��Դϴ�.",
        Count = 5,
        Grade = ItemGrade.Rare
    },

    new ConsumeInfo
    {
        ID = 1006,
        ConsumeType = ConsumeType.Random,
        Name = "�̽� Ŭ���� ���ö�",
        Description = "���� ������ �����ϴ� ���ö��Դϴ�.",
        Count = 3,
        Grade = ItemGrade.Common
    },

    new ConsumeInfo
    {
        ID = 1007,
        ConsumeType = ConsumeType.Unusable,
        Name = "Ű���佺 ���� ����",
        Description = "�������� Ư���� �����۰� ��ȯ�� �� �ִ� �����Դϴ�.",
        Count = 500,
        Grade = ItemGrade.Epic
    },

    new ConsumeInfo
    {
        ID = 1008,
        ConsumeType = ConsumeType.Select,
        Name = "����Ʈ ���� ����",
        Description = "���ϴ� �л��� ����ġ�� ���� ��½�Ű�� �����Դϴ�.",
        Count = 1,
        Grade = ItemGrade.Legendary
    },

    new ConsumeInfo
    {
        ID = 1009,
        ConsumeType = ConsumeType.Random,
        Name = "���л�ȸ ��� ��Ű��",
        Description = "�پ��� ���ڰ� �������� ���Ե� ��� ���� ��Ű���Դϴ�.",
        Count = 2,
        Grade = ItemGrade.Epic
    },

    new ConsumeInfo
    {
        ID = 1010,
        ConsumeType = ConsumeType.Unusable,
        Name = "AP ȸ�� ����",
        Description = "�ൿ���� 120��ŭ ȸ�������ִ� �����Դϴ�.",
        Count = 15,
        Grade = ItemGrade.Common
    }
};
}
#endif