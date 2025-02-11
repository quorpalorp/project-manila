using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparency : MonoBehaviour
{
    public KeyCode click = KeyCode.Mouse0, rClick = KeyCode.Mouse1;
    public SpriteRenderer SpriteRenderer;
    public bool isTrans = false; //alright buddy

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(click))
        {
            Debug.Log("that did something!");
        }
        if (Input.GetKeyDown(rClick))
        {
            if (isTrans == false)
            {
                enable(SpriteRenderer);
                isTrans = true;
            }
            else
            {
                disable(SpriteRenderer);
                isTrans = false;
            }
        }
    }
    private static void enable(SpriteRenderer SpriteRenderer)
    {
        SpriteRenderer.color = new Color(1, 1, 1, 0.25f);
        Debug.Log("enabled");
    }
    private static void disable(SpriteRenderer SpriteRenderer)
    {
        SpriteRenderer.color = new Color(1, 1, 1, 1f);
        Debug.Log("disabled");
    }
}
