using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class descer : MonoBehaviour
{
   public BoxCollider2D box;

   private bool DownDescer = false;
   bool canInterac = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  if (Input.GetKeyDown(KeyCode.S))
        { 
          //permite que personagem passa sobre a parede
          if (DownDescer == true)
          {
               box.isTrigger = true;
          }
           


        }
         
         if(DownDescer == false)
         {
             box.isTrigger = false;
 

         }
      
    
        
    }



     void OnCollisionEnter2D(Collision2D collision)
    { 
      
             
         if (collision.gameObject.tag == "Player")
      {  Debug.Log("descer");
         
         DownDescer = true;
         canInterac = true;
          
        
          
      }
     }

     void OnCollisionExit2D(Collision2D cols)
     { if(cols.gameObject.tag == "Player")
      {
        canInterac = false;
        
      }

     }

      void OnTriggerExit2D(Collider2D col)
    { 

      if(col.gameObject.tag == "Player")
      {
          DownDescer = false;
          canInterac = false;
        

      }

    }
 void OnGUI()
    {
        if(canInterac  == true)
        {
            GUIStyle style = new GUIStyle();
            style.alignment = TextAnchor.MiddleCenter;
            GUI.skin.label.fontSize = 20;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 200, 30), "Pressione 'S' ");

        }
    }




     

     




}
