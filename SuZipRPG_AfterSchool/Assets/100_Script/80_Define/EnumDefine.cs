using UnityEngine;

namespace EnumDefine
{
    // 특수 속성
    public enum AttackType
    {        // 공격 타입
        None = -1,

        EXPLOSIVE,           // 폭발형
        PENETRATION,         // 관통형
        MYSTIC               // 신비형
    };

    public enum ArmorType
    {         // 방어 타입
        None = -1,

        LIGHT_ARMOR,         // 경장갑
        HEAVY_ARMOR,         // 중장갑
        SPECIAL_ARMOR        // 특수장갑
    };

    public enum CombatRole
    {        // 전투 역할
        None = -1,

        STRIKER,             // 스트라이커(공격형)
        SPECIAL              // 스페셜(지원형)
    };

    public enum AttackRange
    {       // 공격 범위
        None = -1,

        FRONT,               // 전방
        REAR                 // 후방
    };

    public enum CombatPosition
    {    // 전투 위치
        None = -1,

        FRONT_LINE,          // 전열
        MIDDLE_LINE,         // 중열
        BACK_LINE            // 후열
    };


    public enum GradeType
    {
        None = -1,

        Common = 0,
        Rare = 1,
        Legendary = 2,
        Epic = 3,

        MAX,
    }

    public enum AbilityReason
    {
        None = -1,

        Level = 0,
        
        Equip1 = 1,
        Equip2 = 2,
        Equip3 = 3,
        Equip4 = 4,

        MAX,
    }

    public enum AbilityType
    {
        None = -1,

        MaxHP = 0,
        AttackPower = 1,
        Defense = 2,
        HealAmount = 3,

        MAX,
    }

    public enum ItemGrade
    {
        None = -1,

        Common,

        Rare,

        Epic, // 보라색

        Legendary, // 전설 

        Max,
    }

    public enum ConsumeType
    {
        None = -1,

        Unusable,

        Select,
        Random,

        Max,
    }

    public enum EuipTier
    {
        None = -1,

        Tier0, 
        Tier1, 
        Tier2, 
        Tier3, 
        Tier4, 
        Tier5, 
        Tier6, 
        Tier7, 
        Tier8, 
        Tier9,

        Max,
    }
}
