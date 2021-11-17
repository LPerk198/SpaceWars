using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float health;

    private float verticalMove;

    public static bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxisRaw("Vertical");
        rb.AddRelativeForce(new Vector3(0.0f, Input.GetAxis("Vertical") * speed * 0.2f, 0.0f));

        transform.Rotate(0.0f, 0.0f, -Input.GetAxis("Horizontal") * speed * 0.3f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            health -= 10;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            isDead = true;
        }
    }
}
