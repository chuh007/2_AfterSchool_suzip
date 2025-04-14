using UnityEngine;

using EnumDefine;
using System.Collections.Generic;


// 이거에 상위로 Actor라는 친구가 Transform이라던지 Rendering 관련 모든 것들을 가지고 있을 거야!
public class StudentCharacter
{
    // 1. 능력치"들"
    public int Id;
    public string Name;
    public int Level;
    public int Exp;

    [SerializeField] public Dictionary<AbilityReason, int> MaxHP = new Dictionary<AbilityReason, int>();
    [SerializeField] public Dictionary<AbilityReason, int> AttackPower = new Dictionary<AbilityReason, int>();
    [SerializeField] public Dictionary<AbilityReason, int> Defense = new Dictionary<AbilityReason, int>();
    [SerializeField] public Dictionary<AbilityReason, int> HealAmount = new Dictionary<AbilityReason, int>();

    // 기타 능력치들이 있지만 여기까지만 일단 합시다

    // 2. 능력치를 집어 넣음
    public void SetAbility(AbilityType abilityType, AbilityReason abilityReason, int amount)
    {
        switch (abilityType)
        {
            case AbilityType.None:
            case AbilityType.MAX:
            default:
                {
                    Debug.Log("잘못된 어빌리티 타입이 입력되었습니다.");
                    return;
                }
            case AbilityType.MaxHP:
                {
                    var debugLogString = string.Empty;
                    if (MaxHP.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"기존 능력치 삭제: {abilityType}, 사유: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        MaxHP.Remove(abilityReason);
                    }

                    debugLogString = $"능력치 추가: {abilityType}, 사유: {abilityReason}, 수치: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    MaxHP.Add(abilityReason, amount);

                    return;
                }
            case AbilityType.AttackPower:
                {
                    var debugLogString = string.Empty;
                    if (AttackPower.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"기존 능력치 삭제: {abilityType}, 사유: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        AttackPower.Remove(abilityReason);
                    }

                    debugLogString = $"능력치 추가: {abilityType}, 사유: {abilityReason}, 수치: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    AttackPower.Add(abilityReason, amount);

                    return;
                }
            case AbilityType.Defense:
                {
                    var debugLogString = string.Empty;
                    if (Defense.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"기존 능력치 삭제: {abilityType}, 사유: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        Defense.Remove(abilityReason);
                    }

                    debugLogString = $"능력치 추가: {abilityType}, 사유: {abilityReason}, 수치: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    Defense.Add(abilityReason, amount);

                    return;
                }
            case AbilityType.HealAmount:
                {
                    var debugLogString = string.Empty;
                    if (HealAmount.TryGetValue(abilityReason, out var value) == true)
                    {
                        debugLogString = $"기존 능력치 삭제: {abilityType}, 사유: {abilityReason}";
                        Log.Message(debugLogString, LogCategory.CharacterStatus);
                        HealAmount.Remove(abilityReason);
                    }

                    debugLogString = $"능력치 추가: {abilityType}, 사유: {abilityReason}, 수치: {value}";
                    Log.Message(debugLogString, LogCategory.CharacterStatus);
                    HealAmount.Add(abilityReason, amount);

                    return;
                }
        }
    }

    // 3. 능력치의 총합을 계산
    public int GetTotalStatus(AbilityType abilityType)
    {
        switch (abilityType)
        {
            case AbilityType.None:
            case AbilityType.MAX:
            default:
                {
                    Debug.Log("잘못된 어빌리티 타입이 입력되었습니다.");

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
    // 3. 계산된 능력치를 반환

    // 4. 왜 해당 능력치가 올랐을까? => AbilityReason을 사용!
}
