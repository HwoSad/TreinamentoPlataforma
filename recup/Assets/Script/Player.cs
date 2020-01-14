using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{   //pega a posição x,y,z
   // para player
      [SerializeField]
       Transform pss;
      
    
    //pega a imagem
    public SpriteRenderer sprite;
    //pega o áudios
    private AudioSource sounds;
   //pega a velocidade
    public float speed = 10f;
   //onde se aplica a regra da física
    public Rigidbody2D rb;

   
   //pega a animação
    public Animator anim;
   
    //receber numeros inteiros e quebrados, negativos e positivos
    //estou usado para movimento
    float  move;
    
    //o numero que é dado para pulo
    public float jumpHeight;
  
   //confirir que o player esta pulando
    public bool isJumping = false;




    // Start is called before the first frame update
    void Start()
    {
           
           
         

          anim.SetBool("inFloor",true);
          anim.SetBool("isMoving",false);
           anim.SetBool("dano",false);

          rb   = GetComponent<Rigidbody2D>();
          anim = GetComponent<Animator>();
          sounds = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

   
     }

    void FixedUpdate()
    {

      playerMovement();
      pulo();
     

    }

     void OnCollisionEnter2D(Collision2D collision)
    { 
      //que o player colidir com o chão, ele não esta pulando
      if( collision.gameObject.tag == "ground")
      { 
        isJumping = false;

        
        


      }
 
      
      if( collision.gameObject.tag == "fire")
      {   
        //se o sprite do player tiver virado para esquerda que é negativo
        //o player vai ser arremessado para direita e o contrário
           if (sprite.flipX == true)
           {
               pss.position = new Vector3 (pss.position.x +2,pss.position.y,pss.position.z);
           }

           
           if (sprite.flipX == false)
           {
               pss.position = new Vector3 (pss.position.x -2,pss.position.y,pss.position.z);
           }

         
      }



    }
    void OnCollisionExit2D(Collision2D collision)
    {
      //que o player não estiver colidindo com chão é porque ele esta pulando
      if( collision.gameObject.tag == "ground")
      { 
        isJumping = true;

        
        


      }
      }

   


    
 
 void playerMovement()
 {
   move = Input.GetAxisRaw("Horizontal");
    
    
        rb.velocity = new Vector2 (move * speed ,rb.velocity.y);
        
        //se o player tiver parado, ele não esta se movendo
        if (move == 0 )
        {

          
        anim.SetBool("isMoving",false);
            
        }

    else
    {
       anim.SetBool("isMoving",true);
        
    }
   //que movimento x for menor que zero o player vai vira para esquerda
   //que movimento x for maior que zero o player vai vira para direita
    if (move < 0)sprite.flipX = true;
    if (move > 0) sprite.flipX = false; 

     

 }

 void pulo()
 {
  
  
      
  
    if (Input.GetKeyDown(KeyCode.Space)&& !isJumping)
    {
      //movimento (x,y)
      rb.velocity = new Vector2 (rb.velocity.x, 1 * jumpHeight);

      //toca a musica

      sounds.Play();
        
    }

    
    if (Input.GetKeyDown(KeyCode.UpArrow)&& !isJumping)
    {
      rb.velocity = new Vector2 (rb.velocity.x, 1 * jumpHeight);


        sounds.Play();
    }
  
  
 }


}
