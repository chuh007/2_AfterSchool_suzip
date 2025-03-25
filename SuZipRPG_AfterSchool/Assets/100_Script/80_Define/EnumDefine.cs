using UnityEngine;

namespace EnumDefine
{
    // Ư�� �Ӽ�
    public enum AttackType
    {        // ���� Ÿ��
        None = -1,

        EXPLOSIVE,           // ������
        PENETRATION,         // ������
        MYSTIC               // �ź���
    };

    public enum ArmorType
    {         // ��� Ÿ��
        None = -1,

        LIGHT_ARMOR,         // ���尩
        HEAVY_ARMOR,         // ���尩
        SPECIAL_ARMOR        // Ư���尩
    };

    public enum CombatRole
    {        // ���� ����
        None = -1,

        STRIKER,             // ��Ʈ����Ŀ(������)
        SPECIAL              // �����(������)
    };

    public enum AttackRange
    {       // ���� ����
        None = -1,

        FRONT,               // ����
        REAR                 // �Ĺ�
    };

    public enum CombatPosition
    {    // ���� ��ġ
        None = -1,

        FRONT_LINE,          // ����
        MIDDLE_LINE,         // �߿�
        BACK_LINE            // �Ŀ�
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
}
