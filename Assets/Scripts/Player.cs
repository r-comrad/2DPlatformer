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
    public float mFlyTime = 0;
    public float mMaxFlyTime = 3;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        velocity = new Vector2(1.75f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        //float dx = Input.GetAxis("Horizontal");
        //rb2D.MovePosition(rb2D.position + Vector2.right * dx * mSpeed * Time.deltaTime);
        //if (mOnGround && Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb2D.AddForce(Vector2.up * 10000);
        //    mOnGround = false;
        //}


        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
        if (dy != 0)
        {
            mOnGround = false;
        }
        if (mOnGround == false)
        {
            mFlyTime -= Time.deltaTime;
            if (mFlyTime <= 0)
            {
                mFlyTime = 0;
                dy = 0;
            }
        }
        
        rb2D.MovePosition(rb2D.position +
            Vector2.right * dx * mSpeed * Time.deltaTime +
            Vector2.up * dy * mSpeed * 2 * Time.deltaTime);


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
            mFlyTime = mMaxFlyTime;
        }
    }
}
