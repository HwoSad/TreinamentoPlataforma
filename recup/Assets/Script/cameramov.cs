using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameramov : MonoBehaviour
{

           int damagem = 2 ;
           int damagem1 = 2;
  public float speed;

 

//cam
[SerializeField]
 Transform ass;
  
 

  //cam
 
   [SerializeField]
    Transform asw;
    
   [SerializeField]
    Transform bs;


  [SerializeField]
    Transform cs;

    Vector3 SA;
   
   Vector3 SB;

   Vector3 nexp;

   Vector3 SC; 

   Vector3 nexp1;

    public bool ms = false;
      public bool ma = false;

   
  
    // Start is called before the first frame update
    void Start()
    {
         SA = asw.localPosition;
        SB =  bs.localPosition;
        SC =  cs.localPosition;

        nexp = SB;

        nexp1 = SC;

    
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ms==true)
        { 
            asw.localPosition = Vector3.MoveTowards(asw.localPosition,nexp,speed * Time.deltaTime );
        
        }
        if (ma==true)
        {
             asw.localPosition = Vector3.MoveTowards(asw.localPosition,nexp1,speed * Time.deltaTime );
        }

         
    }

     void OnTriggerEnter2D(Collider2D col)
    {
      if( col.gameObject.tag == "mscamera")
      { 
         Debug.Log("col");
          
         
          ms = true;
      }
      
      if (col.gameObject.tag == "mscamera1")
      {
          Debug.Log("col");
          ms = false;
         ma = true;
      }
      


    }
    
    void OnTriggerExit2D (Collider2D os )
    {
      
          if( os.gameObject.tag == "mscamera")
      { 
         Debug.Log("col");
          
         
          ms = true;
      }
         if( os.gameObject.tag == "mscamera1")
      { 
         Debug.Log("col");
          
         
          ma = true;
      }
       
      
       if( os.gameObject.tag == "gameover")
      { 
        
         
         ms = false;
         ma = false;
         
        asw.position = ass.position;
        
        
        
      }

   
       

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if( collision.gameObject.tag == "fire")
      {
        damagem --;

        if (damagem <= 0)
        {
            

            damagem = damagem1;

          

            ms = false;
            ma = false;
        }



      }
    }
}

  

  

