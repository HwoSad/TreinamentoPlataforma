using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manu : MonoBehaviour
{
 //botão
    bool sd  = false;
    public void PlayGame()
    {
         
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }

    public void QuitGame()
    {
       
        
        sd= true;
         if (sd == true)
        { Debug.Log("quit");
            Application.Quit();
            
        }
    }

    public void inicio()
    {

       SceneManager.LoadScene(0);


    }

}


