using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public bool hhh = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        Destroy(gameObject);
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    //if (other.tag == "Player" && other is BoxCollider)
    //    if (other.tag == "Player")
    //    {
    //        //Width = spriteRenderer.bounds.size.x;
    //        //spriteRenderer.bounds.size.y;


    //        hhh = true;
    //        Destroy(gameObject);
    //    }
    //}
}
