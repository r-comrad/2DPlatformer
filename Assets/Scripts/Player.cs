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
    public bool mOnGround = false;
    public bool mFaceRight = true;

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

        if (mOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up * 4000);
            mOnGround = false;
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

        if (dx > 0 && !mFaceRight) flip();
        else if (dx < 0 && mFaceRight) flip();
    }

    void flip()
    {
        mFaceRight = !mFaceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            mOnGround = true;
        }
    }
}
