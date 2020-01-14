using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    private AudioSource sounds;
    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {  //som de dano do player ao rela no fogo
      if (collision.gameObject.tag == "Player")
      {
           sounds.Play();
      }

    }
}
