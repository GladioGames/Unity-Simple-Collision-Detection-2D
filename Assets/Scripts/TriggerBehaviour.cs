using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
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

    //Overlapping another Collider 2D
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Change  my spriterenderer color to green
        sprnd.color = Color.green;
    }

    //Stop Overlapping another Collider 2D
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Restore my spriterenderer color to default
        sprnd.color = startColor;
    }
}