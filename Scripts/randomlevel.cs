using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class RandomLevelLoader : MonoBehaviour
{
    // List of level names to load randomly
    public List<string> levelNames;

    // Reference to the button
    public Button yourButton;

    void Start()
    {
        // Ensure the button is assigned
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(OnButtonClick);
        }
    }

    void OnButtonClick()
    {
        // Ensure there are levels in the list
        if (levelNames.Count > 0)
        {
            // Pick a random level from the list
            string randomLevel = levelNames[Random.Range(0, levelNames.Count)];

            // Load the random level
            SceneManager.LoadScene(randomLevel);
        }
        else
        {
            Debug.LogError("No levels found in the list!");
        }
    }
}
