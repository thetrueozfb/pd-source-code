using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Name of the scene to load
    public string sceneName = "TestLevel";
    
    // Variable to store user input
    private string input = "";
    
    void Update()
    {
        // Check for keyboard input
        if (Input.anyKeyDown)
        {
            // Append the pressed key to the input string
            input += Input.inputString;
            
            // Check if the input string contains "test"
            if (input.Contains("test"))
            {
                // Load the scene
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}