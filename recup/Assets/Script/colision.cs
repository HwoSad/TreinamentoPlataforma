using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
  //camera
   [SerializeField]
    Transform cama;
  //onde a camera inicia
     [SerializeField]
      Transform camap;
    
    
   //audio
   public AudioSource soundA;
    public Text a;  //texto do canvas
    public Text b; //texto do canvas
  
  //valor de texto
  string y = "";
    string x = "";

    
    
     //posição do player
     [SerializeField]
       Transform plA;
     //posição inicial do player
       [SerializeField]
       Transform plB;
       //x,y,z
       Vector3 ps;



   public int health ; //vida

   public int damagem; //quantidade de dano que pode levar

   public int damagem1;//quantidade de dano inicial que pode levar


   int vs ;

    // Start is called before the first frame update
    void Start()
    {  
         ps = plB.position;
         
        
        
    }

    // Update is called once per frame
    void Update()
    { 
      //converter class numericas em texto
        x = health.ToString();
        
        a.text = x;

        y = vs.ToString();
        b.text = y;

       //que o player pegar as 5 gemas,ele ganha uma vida
        if (vs == 5)
        {
           health++;

           vs = 0;
            
        }
        //tela de game over
        if (health <= 0)
        {
           SceneManager.LoadScene(2);
            
        }
        
        
    }
      void OnTriggerEnter2D(Collider2D col)
    { 
      // é um objeto que faz o player morrer ao sair da tela 
       if( col.gameObject.tag == "gameover")
      { 
        
        //Debug.Log("player morreu");
       //o player ao morrer reinicia aonde começou 
      
        plA.position = ps;
        health --; // vida -1
        
     

      }

      if (col.gameObject.tag == "gem")
      { //toca o som da coleta, e destroi a gema;
          soundA.Play();

          Destroy(col.gameObject);

          vs ++;

          
      }
    }
void OnCollisionEnter2D(Collision2D collision)
    {
      if( collision.gameObject.tag == "fire")
      { //da dano e volta a camera e o player na posição inicial
        damagem --;

        if (damagem <= 0)
        {
            health --;

            damagem = damagem1;

            plA.position = ps;

            cama.position = camap.position;
        }



      }
    }
}
