using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement speed
    public float speed = 20.0f;         // Forward/back speed
    public float turnSpeed = 10.0f;     // Left/right turning speed

    // Input variables
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
        forwardInput = Input.GetAxis("Vertical");     // W/S or Up/Down arrows

        // Move vehicle forward/backward
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);

        // Rotate vehicle left/right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}