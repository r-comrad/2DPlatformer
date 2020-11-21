﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    public float speed = 20f;
    public float distance;
    public LayerMask whatIsSolid;
    public float mMaxLifeTime = 3;
    public float mLifeTime = 0;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mLifeTime += Time.deltaTime;
        if (mLifeTime > mMaxLifeTime)
        {
            Destroy(gameObject);
        }

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                //hitInfo.collider.GetComponent<Enemy>();
                hitInfo.collider.GetComponent<Enemy>().TakeDamage();
            }
            Destroy(gameObject);
        }

        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
