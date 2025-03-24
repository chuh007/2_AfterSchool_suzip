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
    }
}