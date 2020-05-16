using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    private SpriteRenderer sprnd;
    private Color startColor;

    // Start is called before the first frame update
    void Start()
    {
        //Get my spriterenderer component
        sprnd = GetComponent<SpriteRenderer>();
        //Save the default spriterenderer color 
        startColor = sprnd.color;
    }

    //Hitting another Collider 2D
    private void OnCollisionStay2D(Collision2D collision)
    {
        //If the object hit is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            //Change  my spriterenderer color to red
            sprnd.color = Color.red;
        }
    }

    //Stop hitting another Collider 2D
    private void OnCollisionExit2D(Collision2D collision)
    {
        //Restore my spriterenderer color to default
        sprnd.color = startColor;
    }
}