using UnityEngine;

public class BackAndForthMovement : MonoBehaviour
{
    // The starting position of the sprite
    private Vector3 startPosition;

    // The maximum distance the sprite will move from the start position
    public float distance = 5f;

    // The speed of the back and forth movement
    public float speed = 2f;

    void Start()
    {
        // Save the initial position of the sprite
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using a sine wave
        float newPosition = Mathf.Sin(Time.time * speed) * distance;

        // Apply the new position to the sprite
        transform.position = new Vector3(startPosition.x + newPosition, startPosition.y, startPosition.z);
    }
}
