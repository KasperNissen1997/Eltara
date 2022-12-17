using UnityEngine;

/// <summary>
/// PlayerController receives and processes user input, and applies movement to an associated Rigidbody2d component. 
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    #region Component references
    private Rigidbody2D rigidbody2d;
    #endregion

    [Range(0.1f, 10)]
    public float speed = 1;

    private float inputHorizontal; 
    private float inputVertical;

    private Vector2 movementDirection;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector2(inputHorizontal, inputVertical).normalized;

        // attempts to move the rigidbody
        rigidbody2d.MovePosition(rigidbody2d.position + movementDirection * speed * Time.fixedDeltaTime);
    }
}
