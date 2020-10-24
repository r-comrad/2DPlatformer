using System.Collections;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mSpeed = 20f;
    private Vector2 velocity;
    private Rigidbody2D rb2D;
    public float dy = 0.0f;

    //protected R

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        velocity = new Vector2(1.75f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        //rb.MovePosition(rb.position + Vector2.right * dx * spped);
        //transform.position = new Vector3(a * (float)Math.Cos(mAlpha), b * (float)Math.Sin(mAlpha), 1f);
        rb2D.MovePosition(rb2D.position + Vector2.right * dx * mSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up * 4000);
        }

        //if (dy > 1e-5 || Input.GetKeyDown(KeyCode.Space))
        //{
        //    //rb2D.AddForce(Vector2.up * 4000);
        //    dy = 1;
        //    //rb2D.MovePosition(rb2D.position + Vector2.up * dy * mSpeed * Time.deltaTime);
        //}
        //else
        //{
        //    dy = 0;
        //}
        //if (dy > 1e-5) dy -= 0.1f;

    }
}
