using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    private Rigidbody2D characterRigidbody;
    public static Animator characterAnimator;
    private float horizontalInput;
   [SerializeField]private float characterSpeed = 4.5f;
   [SerializeField]private float jumpForce = 8;
    void Awake()
        {
            characterRigidbody = GetComponent<Rigidbody2D>();
            characterAnimator = GetComponent <Animator>();
        }


    void Update()
        {
            Movement();

            if(Input.GetButtonDown("Jump") && GroundSensor.isGrounded)
            {
            Jump();
            }     
        }
    void Movement()
    {
        if(inputHorizontal < 0)
                {
                    transform.rotation = Quaternion.Euler(0, 100, 0);
                    anim.SetBool("IsRunning", true);
                }
                else if (inputHorizontal > 0)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    anim.SetBool("IsRunning", true);
                }
                else
                {
                anim.SetBool("IsRunning", false);  
                }
    }

    void Jump()
        {
    characterRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            characterAnimator.SetBool("isjumping", true);
        }


}
