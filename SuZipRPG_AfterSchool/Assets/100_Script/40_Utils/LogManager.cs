using System.Collections.Generic;
using UnityEngine;

namespace _100_Script._40_Utils
{
    
    public enum LogCategory
    {
        None = -1,
            
        CharacterEquip,
        CharacterSkill,
        CharacterStar,
        Character,
        
        Inventory,
        InventoryConsume,
        InventoryEquip,
        
        Max
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
}