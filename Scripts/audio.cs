using UnityEngine;

public class LoopingSoundVolumeController : MonoBehaviour
{
    public Transform playerTransform;
    public AudioSource audioSource;

    // Adjust these values to control the minimum and maximum volume distances
    public float minDistance = 1f;
    public float maxDistance = 10f;

    void Update()
    {
        if (playerTransform == null || audioSource == null)
            return;

        // Calculate the distance between the player and the sound source
        float distanceToPlayer = Vector2.Distance(transform.position, playerTransform.position);

        // Calculate the volume based on the distance
        float volume = Mathf.Clamp01(1f - (distanceToPlayer - minDistance) / (maxDistance - minDistance));

        // Set the volume of the audio source
        audioSource.volume = volume;

        // If the audio source is not playing, start playing it
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
