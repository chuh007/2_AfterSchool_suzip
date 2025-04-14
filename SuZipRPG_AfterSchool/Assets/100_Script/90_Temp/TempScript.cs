using UnityEngine;
using EnumDefine;
using UnityEditor.SceneManagement;

public class TempScript : MonoBehaviour
{
    [SerializeField] public StudentCharacter character;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        character = new StudentCharacter();

        character.SetAbility(AbilityType.MaxHP, AbilityReason.Level, 1);
        character.SetAbility(AbilityType.MaxHP, AbilityReason.Equip1, 20);
        character.SetAbility(AbilityType.MaxHP, AbilityReason.Equip2, 300);
        character.SetAbility(AbilityType.MaxHP, AbilityReason.Equip3, 3000);
        character.SetAbility(AbilityType.MaxHP, AbilityReason.Equip3, 4000);

        Debug.Log(character.GetTotalStatus(AbilityType.MaxHP));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
