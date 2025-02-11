using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class basicattack : MonoBehaviour
{
    public enemyPos enemyPos;
    private bool backCheck;
    public transparency transparency;
    public GameObject playerTransform;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.GetComponent<transparency>().isTrans == true)
        {
            backCheck = true;
        }
        else
        {
            backCheck = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (enemyPos.isBack && backCheck == true)
            {
                Debug.Log("DESTROYED");
                Destroy(gameObject);
            }
            else if (enemyPos.isBack && backCheck == false)
            {
                Debug.Log("DESTROYED");
                Destroy(gameObject);
            }
            else
            {
               Debug.Log("CLICK REGISTERED, NO ACTION");
            }
        }
    }

    private void OnMouseDown()
    {
        
    }
}
