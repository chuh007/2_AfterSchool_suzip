using UnityEngine;

public class UI : MonoBehaviour
{
    private void Start()
    {
        SetDeckController();
        SetSkillUpController();
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
    
    
}
