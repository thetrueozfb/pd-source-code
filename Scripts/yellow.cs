using UnityEngine;

public class YellowBlock : MonoBehaviour
{
    private Collider2D blockCollider;
    private SpriteRenderer spriteRenderer;

    public Sprite state1Sprite; // Sprite for state 1
    public Sprite state2Sprite; // Sprite for state 2

    private bool isState1 = true; // Start in state 1

    private void Start()
    {
        blockCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateState();
    }

    public void ToggleState()
    {
        isState1 = !isState1;
        UpdateState();
    }

    private void UpdateState()
    {
        if (isState1)
        {
            blockCollider.isTrigger = false; // Impassable (collider active)
            spriteRenderer.sprite = state1Sprite;
        }
        else
        {
            blockCollider.isTrigger = true; // Passable (collider inactive)
            spriteRenderer.sprite = state2Sprite;
        }
    }
}
