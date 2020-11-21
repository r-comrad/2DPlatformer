using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acheles : MonoBehaviour
{
    public GameObject mEnemy;
    public bool hhh = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            hhh = true;
            Destroy(mEnemy);
            Destroy(gameObject);
        }
    }
}
