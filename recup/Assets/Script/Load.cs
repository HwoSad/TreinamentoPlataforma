using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
   
    public int loadScene;
    bool canInteract = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canInteract == true && Input.GetKeyDown(KeyCode.E))
        {
            
            SceneManager.LoadScene(loadScene);

        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canInteract = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canInteract = false;
    }

    void OnGUI()
    {
        if(canInteract == true)
        {
            GUIStyle style = new GUIStyle();
            style.alignment = TextAnchor.MiddleCenter;
            GUI.skin.label.fontSize = 20;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 200, 30), "Pressione 'E' ");

        }
    }
}
