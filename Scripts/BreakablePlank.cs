using UnityEngine;

public class BreakablePlank : MonoBehaviour
{
    // Reference to the plank's rigidbody
    private Rigidbody2D rb;

    // Boolean to track whether the plank has been touched
    private bool touched = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D component attached to the plank
        rb = GetComponent<Rigidbody2D>();
    }

    // Function to handle when the player touches the plank
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !touched)
        {
            touched = true; // Set touched to true to prevent multiple calls
            Invoke("BreakPlank", 1f); // Invoke the BreakPlank function after 1 second
        }
    }

    // Function to break the plank
    private void BreakPlank()
    {
        // Disable the Rigidbody2D component to let the plank fall
        rb.simulated = false;

        // Optionally, you can also play a sound effect or particle effect here

        // Destroy the plank after a few seconds (for cleanup)
        Destroy(gameObject, 1f); // Destroy the game object after 3 seconds
    }
}