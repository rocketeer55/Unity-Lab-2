using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;

    private Rigidbody2D rb2d;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        speed = 1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(player.transform.position.x - transform.position.x,
            player.transform.position.y - transform.position.y);

        rb2d.AddForce(movement * speed);
    }
}
