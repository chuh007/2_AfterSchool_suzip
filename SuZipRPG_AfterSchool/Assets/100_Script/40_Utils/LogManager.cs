using System.Collections.Generic;
using UnityEngine;

public enum LogCategory
{
    None = -1,

    CharacterEquip,
    CharacterSkill,
    CharacterStar,
    CharacterStatus,

    InventoryConsume,
    InventoryEquip,

    Max,
}

public class LogManager : MonoBehaviour
{
    public bool IsLogOn = false;

    public List<bool> IsLogCategoryOn = new List<bool>();

    public void Initialize()
    {
        for (int i = 0; i < (int)LogCategory.Max; i++)
        {
            IsLogCategoryOn.Add(false);
        }
    }
}
