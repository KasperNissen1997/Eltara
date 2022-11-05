using UnityEngine;

[CreateAssetMenu(fileName = "New consumable", menuName = "Eltara Custom Objects/ScriptableObjects/Items/Consumable")]
public class Consumable : Item, IConsumable
{
    [Header("Consumable settings")]
    public int healthChange = 0;
    public int stamineChange = 0; 
    public int manaChange = 0;

    public void Consume (Character character) {
        character.ChangeAttribute(healthChange, AttributeType.health);
        character.ChangeAttribute(stamineChange, AttributeType.stamina);
        character.ChangeAttribute(manaChange, AttributeType.mana);
    }
}