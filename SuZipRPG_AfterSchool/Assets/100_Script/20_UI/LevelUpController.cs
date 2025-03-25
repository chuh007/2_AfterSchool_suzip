using ClassDefine;
using EnumDefine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelUpController : MonoBehaviour, IUI
{
    public ButtonController[] ButtonArray = new ButtonController[6];
    public TextView[] StatusTextArray = new TextView[6];

    public int StackExp;
    public int NeedGold;

    public void Initialize()
    {
        foreach (var button in ButtonArray)
        {
            button.Initialize();
        }

        ButtonArray[0].SetButtonAction(SetExpCommon);
        ButtonArray[1].SetButtonAction(SetExpRare);
        ButtonArray[2].SetButtonAction(SetExpLegendary);
        ButtonArray[3].SetButtonAction(SetExpEpic);
        ButtonArray[4].SetButtonAction(() => { Debug.Log("�ڵ����� ���� ��"); });
        ButtonArray[5].SetButtonAction(() => { Debug.Log("���� �� ���� ��"); });
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        // ���� ������Ʈ�� ������
    }

    private void SetExpCommon()
    {
        StackExp += 1;
        NeedGold += 1;

        StatusTextArray[5].SetText(NeedGold);
    }

    private void SetExpRare()
    {
        StackExp += 2;
        NeedGold += 2;

        StatusTextArray[5].SetText(NeedGold);
    }

    private void SetExpLegendary()
    {
        StackExp += 3;
        NeedGold += 3;

        StatusTextArray[5].SetText(NeedGold);
    }

    private void SetExpEpic()
    {
        StackExp += 4;
        NeedGold += 4;

        StatusTextArray[5].SetText(NeedGold);
    }


    private void SetStatusText()
    {
        if(Manager.Data.StudentLevelStatusDictionary.TryGetValue(0, out List<StudentLevelStatusInfo> targetStudentLevelDataList) == false)
        {
            Debug.LogError("ID ���� 0�� �л��� ã�� ���� �����ϴ�"); // => ���� ������ ���� �ڵ带 ������ ���
            // ���� ��Ȳ�� ���� �� ������ ����ǵ��� ����
        }
        StudentLevelStatusInfo currentTargetStudentData = targetStudentLevelDataList.FirstOrDefault(student => student.Level == 1);
        
        StatusTextArray[0].SetText(currentTargetStudentData.Level);
        StatusTextArray[1].SetText(currentTargetStudentData.MaxHP);
        StatusTextArray[2].SetText(currentTargetStudentData.AttackPower);
        StatusTextArray[3].SetText(currentTargetStudentData.Defense);
        StatusTextArray[4].SetText(currentTargetStudentData.HealAmount);

        StatusTextArray[5].SetText(NeedGold);
    }
}
