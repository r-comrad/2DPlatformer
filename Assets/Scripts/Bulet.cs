using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    public float speed;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance);
        //if (hitInfo.collider.CompareTag("Enemy"))
        {
            //hitInfo.collider.GetComponent<Enemy>().TakeDamage();
        }
        //Destoy(gameObject);
    }
}
