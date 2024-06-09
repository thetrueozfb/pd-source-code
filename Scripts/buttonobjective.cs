using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    public YellowBlock yellowBlock; // Assign the yellow block in the Inspector

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            yellowBlock.ToggleState();
        }
    }
}
