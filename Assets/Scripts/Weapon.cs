﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float offset = -135;
    public GameObject bullet;
    public Transform shotPoint;
    // Start is called before the first frame update

    public float shotPeriod = 1;
    public float timeFromShot;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        timeFromShot -= Time.deltaTime;
        if (timeFromShot <= 0.1f)
        {
            timeFromShot = 0;
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeFromShot = shotPeriod;
            }
        }
    }
}


