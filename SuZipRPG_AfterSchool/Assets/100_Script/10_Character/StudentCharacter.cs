using System;
using System.Collections.Generic;
using EnumDefine;
using UnityEngine;

public class StudentCharacter : MonoBehaviour
{
    // 1. 능력치"들"
    public int Level;
    public int Exp;

    public Dictionary<AbilityReason, int> MaxHp = new Dictionary<AbilityReason, int>();
    public Dictionary<AbilityReason, int> AttackPower = new Dictionary<AbilityReason, int>();
    public Dictionary<AbilityReason, int> Defense = new Dictionary<AbilityReason, int>();
    public Dictionary<AbilityReason, int> HealAmount = new Dictionary<AbilityReason, int>();

    // 기타 능력치들이 있지만 여기까지만 일단 함.
    
    // 2. 능력치를 집어 넣음
    public void SetAbility(AbilityType abilityType ,AbilityReason reason, int amount)
    {
        switch (abilityType)
        {
            case AbilityType.None:
            case AbilityType.MAX:
            default:
                Debug.Log("잘못된 어빌리티 타입");
                break;
            case AbilityType.MaxHp:
            {
                if (MaxHp.TryGetValue(reason, out int value) == true) MaxHp.Remove(reason);
                MaxHp[reason] = amount;
                break;
            }
            case AbilityType.AttackPower:
            {
                if (AttackPower.TryGetValue(reason, out int value) == true) MaxHp.Remove(reason);
                AttackPower[reason] = amount;
                break;
            }
            case AbilityType.Defense:{
                if (Defense.TryGetValue(reason, out int value) == true) MaxHp.Remove(reason);
                Defense[reason] = amount;
                break;
            }
            case AbilityType.HealAmount:{
                if (HealAmount.TryGetValue(reason, out int value) == true) MaxHp.Remove(reason);
                HealAmount[reason] = amount;
                break;
            }
        }
    }
    
    // 2. 능력치의 총합을 계산
    private int TotalStatus(AbilityType abilityType)
    {
        int totalValue = 0;
        switch (abilityType)
        {
            case AbilityType.None:
            case AbilityType.MAX:
            default:
                Debug.Log("잘못된 어빌리티 타입");
                return 0;
            case AbilityType.MaxHp:
                foreach (var reasonValue in MaxHp) totalValue += reasonValue.Value;
                return totalValue;
            case AbilityType.AttackPower:
                foreach (var reasonValue in AttackPower) totalValue += reasonValue.Value;
                return totalValue;
            case AbilityType.Defense:
                foreach (var reasonValue in Defense) totalValue += reasonValue.Value;
                return totalValue;
            case AbilityType.HealAmount:
                foreach (var reasonValue in HealAmount) totalValue += reasonValue.Value;
                return totalValue;
            
        }
        return 0;
    }
    
    // 3. 계산된 능력치를 반환

    // 4. 왜 해당 늘력치가 올랐을까? => AbilityReason을 사용


}
