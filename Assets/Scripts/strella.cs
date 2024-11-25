using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class strella : MonoBehaviour
{
   
    private bool interectable;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && interectable)
        {
            SceneManager.LoadScene("Victoria");
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
