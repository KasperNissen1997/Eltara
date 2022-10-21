using UnityEngine;

public class CharacterController : MonoBehaviour {
    #region Unity dependencies
    CharacterResources Resources { get; set; }
    #endregion

    public bool Alive { get; private set; } = true;

    public void Awake () {
        Resources = GetComponent<CharacterResources>();
    }

    public virtual void Kill () {
        Alive = false;

        Debug.Log(name + " has been killed.");
    }
}
