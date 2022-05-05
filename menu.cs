using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
     public void ZmienScene()
     {
         SceneManager.LoadScene(1);
     }
          public void jedz()
     {
         SceneManager.LoadScene(2);
     }
     public void Wyjdz()
     {
         Application.Quit();
     }
}
