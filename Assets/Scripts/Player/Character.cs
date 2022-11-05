using UnityEngine;

public class Character : MonoBehaviour
{
    public bool alive = true;

    [Header("Health settings")]
    public int maxHealth = 100;
    [SerializeField]
    int health = 100;

    [Header("Stamina settings")]
    public int maxStamina = 100;
    [SerializeField]
    int stamina = 100;

    [Header("Mana settings")]
    public int maxMana = 100;
    [SerializeField]
    int mana = 100;

    public void ChangeAttribute (int amount, AttributeType attribute) {
        switch (attribute) {
            case AttributeType.health:
                health += amount;

                if (health <= 0)
                    Kill();
                break;

            case AttributeType.stamina:
                stamina += amount;
                break;

            case AttributeType.mana:
                mana += amount;
                break;
        }
    }

    public void Kill () {
        alive = false;

        Debug.Log(name + " has been killed!");
    }
}