using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour 
{
 [SerializeField] public string newLevel;

 void OnTriggerEnter2D(Collider2D other)
 {
 if(other.CompareTag("Player"))
  {
   SceneManager.LoadScene (newLevel);
  }
 }
}