using UnityEngine;

public class UI : MonoBehaviour
{
    private void Start()
    {
        //SetDeckController();
        //SetSkillUpController();
        //SetEquipUpController();
        SetInventoryConsumeController();
    }

    public static DeckController DeckController { get; private set; }

    private void SetDeckController()
    {
        DeckController = GetComponentInChildren<DeckController>();
        DeckController.Initialize();
    }

    public static SkillUpController SkillUpController { get; private set; }

    private void SetSkillUpController()
    {
        SkillUpController = GetComponentInChildren<SkillUpController>();
        SkillUpController.Initialize();
    }

    public static EquipUpController EquipUpController { get; private set; }

    private void SetEquipUpController()
    {
        EquipUpController = GetComponentInChildren <EquipUpController>();
        EquipUpController.Initialize();
    }
    
    public static InventoryConsumeController InventoryConsumeController { get; private set; } = new InventoryConsumeController();

    private void SetInventoryConsumeController()
    {
        InventoryConsumeController = GetComponentInChildren<InventoryConsumeController>();
        InventoryConsumeController.Initialize();
    }
}
