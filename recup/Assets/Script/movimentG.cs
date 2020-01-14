using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentG : MonoBehaviour
{
   
   //posição A
   Vector3 posA;
   //posição B
   Vector3 POsB;
  //Proxima posição
   Vector3 nexPos;

  
//objeto que vai se mover
   [SerializeField]
   Transform transA;

   [SerializeField]
//até onde ele vai
   Transform transB;
//velocidade
   [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {  
        posA = transA.localPosition;
        POsB = transB.localPosition;

        nexPos = POsB;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {     // usado para o objeto não se mover mais que deveria
        transA.localPosition = Vector3.MoveTowards(transA.localPosition,nexPos,speed * Time.deltaTime);
        
        //retorna a distancia entra a,b
        if (Vector3.Distance(transA.localPosition,nexPos) <= 0.1)
        {
            ver();
            
        }


    }

    void ver()
    {

        //nexpos é igaul a nexpos que é desigual a posiçãoA então prencisamos usar posição a ou b
        nexPos = nexPos != posA ? posA : POsB;
    }
}
