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
}