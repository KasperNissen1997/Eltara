using UnityEngine;

public class PlayerController : CharacterController {
    public void Update () {

    }

    public override void Kill () {
        base.Kill();

        Debug.Log("Game Over!");
    }
}
