using UnityEngine;
using UnityEngine.SceneManagement;
 
public class kmn : MonoBehaviour
{
    public void killme()
    {
        SceneManager.LoadScene("Level2");
    }
}