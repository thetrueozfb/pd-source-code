using UnityEngine;

public class AnimationToSpriteSwitcher : MonoBehaviour
{
    public Sprite staticSprite; // Assign the static sprite in the Inspector
    public Vector2 staticSpriteColliderSize; // Assign the new collider size for the static sprite
    public Vector2 staticSpriteColliderOffset; // Assign the new collider offset for the static sprite

    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private BoxCollider2D boxCollider;

    void Start()
    {
        // Get the SpriteRenderer, Animator, and BoxCollider2D components attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();

        // Ensure the static sprite and collider parameters are assigned
        if (staticSprite == null)
        {
            Debug.LogError("Static sprite not assigned!");
        }
        if (boxCollider == null)
        {
            Debug.LogError("BoxCollider2D not found on the GameObject!");
        }
    }

    void Update()
    {
        // Check if the 'c' key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Check if the 'd' key is also pressed
            if (Input.GetKeyDown(KeyCode.D))
            {
                // Switch from animation to the static sprite
                if (animator != null && spriteRenderer != null && staticSprite != null && boxCollider != null)
                {
                    animator.enabled = false; // Disable the Animator component
                    spriteRenderer.sprite = staticSprite; // Set the static sprite

                    // Update the BoxCollider2D size and offset
                    boxCollider.size = staticSpriteColliderSize;
                    boxCollider.offset = staticSpriteColliderOffset;

                    // Log collider size and offset for debugging
                    Debug.Log($"Collider size set to: {boxCollider.size}");
                    Debug.Log($"Collider offset set to: {boxCollider.offset}");
                }
            }
        }
    }
}
