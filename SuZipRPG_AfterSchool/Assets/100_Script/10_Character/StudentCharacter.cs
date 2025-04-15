using UnityEngine;

using EnumDefine;
using System.Collections.Generic;


// �̰ſ� ������ Actor��� ģ���� Transform�̶���� Rendering ���� ��� �͵��� ������ ���� �ž�!
public class StudentCharacter
{
    // 1. �ɷ�ġ"��"
    public int Id;
    public string Name;
    public int Level;
    public int Exp;

    [SerializeField] public Dictionary<AbilityReason, int> MaxHP = new Dictionary<AbilityReason, int>();
    [SerializeField] public Dictionary<AbilityReason, int> AttackPower = new Dictionary<AbilityReason, int>();
    [SerializeField] public Dictionary<AbilityReason, int> Defense = new Dictionary<AbilityReason, int>();
    [SerializeField] public Dictionary<AbilityReason, int> HealAmount = new Dictionary<AbilityReason, int>();

    // ��Ÿ �ɷ�ġ���� ������ ��������� �ϴ� �սô�

    // 2. �ɷ�ġ�� ���� ����
    public void SetAbility(AbilityType abilityType, AbilityReason abilityReason, int amount)
    {
        switch (abilityType)
        {
            case AbilityType.None:
            case AbilityType.MAX:
            default:
                {
                    Debug.Log("�߸��� �����Ƽ Ÿ���� �ԷµǾ����ϴ�.");
                    return;
                }
            case AbilityType.MaxHP:
                {
                    var debugLogString = string.Empty;
                    if (MaxHP.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"���� �ɷ�ġ ����: {abilityType}, ����: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        MaxHP.Remove(abilityReason);
                    }

                    debugLogString = $"�ɷ�ġ �߰�: {abilityType}, ����: {abilityReason}, ��ġ: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    MaxHP.Add(abilityReason, amount);

                    return;
                }
            case AbilityType.AttackPower:
                {
                    var debugLogString = string.Empty;
                    if (AttackPower.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"���� �ɷ�ġ ����: {abilityType}, ����: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        AttackPower.Remove(abilityReason);
                    }

                    debugLogString = $"�ɷ�ġ �߰�: {abilityType}, ����: {abilityReason}, ��ġ: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    AttackPower.Add(abilityReason, amount);

                    return;
                }
            case AbilityType.Defense:
                {
                    var debugLogString = string.Empty;
                    if (Defense.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"���� �ɷ�ġ ����: {abilityType}, ����: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        Defense.Remove(abilityReason);
                    }

                    debugLogString = $"�ɷ�ġ �߰�: {abilityType}, ����: {abilityReason}, ��ġ: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    Defense.Add(abilityReason, amount);

                    return;
                }
            case AbilityType.HealAmount:
                {
                    var debugLogString = string.Empty;
                    if (HealAmount.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"���� �ɷ�ġ ����: {abilityType}, ����: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        HealAmount.Remove(abilityReason);
                    }

                    debugLogString = $"�ɷ�ġ �߰�: {abilityType}, ����: {abilityReason}, ��ġ: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    HealAmount.Add(abilityReason, amount);

                    return;
                }
        }
    }

    // 3. �ɷ�ġ�� ������ ���
    public int GetTotalStatus(AbilityType abilityType)
    {
        switch (abilityType)
        {
            case AbilityType.None:
            case AbilityType.MAX:
            default:
                {
                    Debug.Log("�߸��� �����Ƽ Ÿ���� �ԷµǾ����ϴ�.");

                    return 0;
                }
            case AbilityType.MaxHP:
                {
                    int totalValue = 0;
                    foreach (var reasonValue in MaxHP)
                    {
                        totalValue += reasonValue.Value;
                    }

                    return totalValue;
                }
            case AbilityType.AttackPower:
                {
                    int totalValue = 0;
                    foreach (var reasonValue in AttackPower)
                    {
                        totalValue += reasonValue.Value;
                    }

                    return totalValue;
                }
            case AbilityType.Defense:
                {
                    int totalValue = 0;
                    foreach (var reasonValue in Defense)
                    {
                        totalValue += reasonValue.Value;
                    }

                    return totalValue;
                }
            case AbilityType.HealAmount:
                {
                    int totalValue = 0;
                    foreach (var reasonValue in HealAmount)
                    {
                        totalValue += reasonValue.Value;
                    }

                    return totalValue;
                }
        }
    }
    // 3. ���� �ɷ�ġ�� ��ȯ

    // 4. �� �ش� �ɷ�ġ�� �ö�����? => AbilityReason�� ���!
}
