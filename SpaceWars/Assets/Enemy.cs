using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private Transform player;

    private void Start()
    {
        if(GameObject.FindWithTag("Player") != null)
        {
            player = GameObject.FindWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!Player.isDead)
        {
            var offset = -90f;
            Vector2 direction = player.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));

            rb.AddRelativeForce(new Vector3(0.0f, 1 * speed * 0.2f, 0.0f));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Projectile"))
        {
            Destroy(gameObject);
            GameOver.enemiesKilled++;
        }
        
    }
}
