using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private bool interectable;
           void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && interectable)
        {
            GameManager.instance.AddCoin();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            interectable = true;
        }
    }

     void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
             
            interectable = false;
        }
    }
}
