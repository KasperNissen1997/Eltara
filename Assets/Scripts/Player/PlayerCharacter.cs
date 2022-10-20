using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public bool Alive { get; private set; }

    int _health;
    public int Health {
        get { 
            return _health; 
        }

        set {
            if (value <= 0)
                Kill();
            
            _health = value;
        }
    }

    public int Stamina { get; set; }
    public int Mana { get; set; }

    public void Kill () {
        Alive = false;
    }
}
