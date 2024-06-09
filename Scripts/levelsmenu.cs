using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Change : MonoBehaviour
{
    public void NextShot()
    {
        SceneManager.LoadScene("levels");
    }
}