 using UnityEngine;
 using System.Collections;
 
 public class urlbutton : MonoBehaviour
 {
     public void OpenURL()
     {
         Application.OpenURL("https://www.youtube.com/playlist?list=PLTyGSD7AFc6Crzeyw0uLOoHlxwTVpRNYe");
         Debug.Log("is this working?");
     }
 
 }