using System;
using EnumDefine;

namespace ClassDefine
{
    [Serializable]
    public class StudentInfo
    {
        public int Id;
        public String Name;
        public int Level;
        public int Exp;

        // �⺻ ����
        public int Hp;                  // ü��
        public int AttackPower;         // ���ݷ�
        public int Defense;             // ����
        public int HealAmount;          // ����
        public float HitRate;           // ���߷� (%)
        public float EvasionRate;       // ȸ���� (%)
        public float CriticalRate;      // ġ��Ÿ�� (%)
        public float CriticalDamage;    // ġ��Ÿ ������ (%)
        public float CcResistance;      // CC ���� (%)
        public float CostRecovery;      // ��� ȸ����
                                        
        // ĳ���� Ư��
        public AttackType AttackType;        // ���� Ÿ��
        public ArmorType ArmorType;          // ��� Ÿ��
        public CombatRole CombatRole;        // ���� ����
        public AttackRange AttackRange;      // ���� ����
        public CombatPosition CombatPosition; // ���� ��ġ
                                              
        // �ΰ� ����
        public int StreetCombatPower;    // ��Ʈ��Ʈ ������
        public int IndoorCombatPower;   // �ǳ� ������
        public int OutdoorCombatPower;  // �߿� ������
    }

    [Serializable]
    public class StudentLevelStatusInfo // => List�� ����
    {
        public int Level;
        public int Exp;

        public int MaxHP;
        public int AttackPower;
        public int Defense;
        public int HealAmount;
    }
}
