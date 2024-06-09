using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float followSpeed = 5f;

    void Update()
    {
        if (playerTransform != null)
        {
            // Get the target position with the same Y position as the object
            Vector3 targetPosition = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);

            // Move towards the target position
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
