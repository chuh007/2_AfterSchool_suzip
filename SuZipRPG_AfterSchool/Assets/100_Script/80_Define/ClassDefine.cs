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

        // 기본 스탯
        public int Hp;                  // 체력
        public int AttackPower;         // 공격력
        public int Defense;             // 방어력
        public int HealAmount;          // 힐량
        public float HitRate;           // 명중률 (%)
        public float EvasionRate;       // 회피율 (%)
        public float CriticalRate;      // 치명타율 (%)
        public float CriticalDamage;    // 치명타 데미지 (%)
        public float CcResistance;      // CC 저항 (%)
        public float CostRecovery;      // 비용 회복량
                                        
        // 캐릭터 특성
        public AttackType AttackType;        // 공격 타입
        public ArmorType ArmorType;          // 방어 타입
        public CombatRole CombatRole;        // 전투 역할
        public AttackRange AttackRange;      // 공격 범위
        public CombatPosition CombatPosition; // 전투 위치
                                              
        // 부가 스탯
        public int StreetCombatPower;    // 스트리트 전투력
        public int IndoorCombatPower;   // 실내 전투력
        public int OutdoorCombatPower;  // 야외 전투력
    }

    [Serializable]
    public class StudentLevelStatusInfo // => List로 관리
    {
        public int Level;
        public int Exp;

        public int MaxHP;
        public int AttackPower;
        public int Defense;
        public int HealAmount;
    }

    public class ConsumeInfo : ItemInfo
    {
        //public uint ID;

        //public string Name;
        //public string Description;

        //public int Count;

        //public ItemGrade Grade;

        public ConsumeType ConsumeType;

        public String IconName;
    }

    public class EquipInfo : ItemInfo
    {
        //public uint ID;

        //public string Name;
        //public string Description;

        //public int Count;

        //public ItemGrade Grade;

        // 능력치 정보들
        public int MaxHP;
        public int AttackPower;

        public String IconName;
    }

    public class ItemInfo
    {
        public uint ID;

        public string Name;
        public string Description;

        public int Count;

        public ItemGrade Grade;
    }
}
