using UnityEngine;

public class BoulderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the player GameObject
            Destroy(collision.gameObject);
        }
    }
}
