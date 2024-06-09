using UnityEngine;

public class SlimeBehavior : MonoBehaviour
{
    // Movement variables
    private Vector3 startPosition;
    public float distance = 5f;
    public float speed = 2f;

    // Variables to handle collision detection
    public GameObject player; // Assign the player GameObject in the Inspector
    public float topTouchOffset = 0.1f; // Offset to determine top side touch

    void Start()
    {
        // Save the initial position of the slime
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using a sine wave
        float newPosition = Mathf.Sin(Time.time * speed) * distance;

        // Apply the new position to the slime
        transform.position = new Vector3(startPosition.x + newPosition, startPosition.y, startPosition.z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if the player is touching the top of the slime
            Vector3 contactPoint = collision.contacts[0].point;
            BoxCollider2D slimeCollider = GetComponent<BoxCollider2D>();
            Vector3 slimeBoundsCenter = slimeCollider.bounds.center;
            float slimeBoundsTop = slimeCollider.bounds.max.y;

            // Player's position
            Vector3 playerBoundsBottom = collision.collider.bounds.min;

            if (playerBoundsBottom.y >= slimeBoundsTop - topTouchOffset)
            {
                // Player touched the top of the slime, so kill the slime
                Debug.Log("Slime killed");
                Destroy(gameObject);
            }
            else
            {
                // Player touched any other side of the slime, so kill the player
                Debug.Log("Player killed");
                Destroy(collision.gameObject);
            }
        }
    }
}
