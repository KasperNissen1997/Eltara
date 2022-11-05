using UnityEngine;

public class CharacterResources : MonoBehaviour {
    #region Unity dependencies
    CharacterController controller { get; set; }
    #endregion

    void Awake () {
        controller = GetComponent<CharacterController>();
    }

    public int maxHealth = 100, health = 100;
    public int maxStamina = 100, stamina = 100;
    public int maxMana = 100, mana = 100;

    public void ChangeHealth (int value) {
        health += value;

        if (health <= 0)
            controller.Kill();
    }

    public void ChangeStamina (int value) {
        stamina += value;
    }

    public void ChangeMana (int value) {
        mana += value;
    }
}
