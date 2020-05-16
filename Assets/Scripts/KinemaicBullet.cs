using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KinemaicBullet : MonoBehaviour
{
    public float speed = 1.2f;
    private Rigidbody2D rb2d;
    private Vector2 direction = Vector2.down;

    // Start is called before the first frame update
    void Start()
    {
        //Get my Rigidbody 2D component
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //If the position of my Rigidbody 2D reach a certain bottom or top y
        if (rb2d.transform.position.y < -4.24)
        {
            //Change direction to up
            direction = Vector2.up;

        } else if (rb2d.transform.position.y > 4.24)
        {
            //Change direction to down
            direction = Vector2.down;
        }
    }

    //Physics stuff here ;)
    void FixedUpdate()
    {
        //Move my Rigidbody 2D position according to the new direction
        rb2d.MovePosition(rb2d.position + direction * speed * Time.fixedDeltaTime);
    }

    //Just hit another Collider 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Game Over - Back to menu
        SceneManager.LoadScene("Menu");
    }
}
