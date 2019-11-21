  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
   {
    private CharacterController controller;

    private float VertiavlVerlocity;
    private float gravity = 14.0f;
    private float jumpForce = 10.0f;
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
      
        float Horizintal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        bool Sprint = Input.GetButton("Sprint");
        bool Jump = Input.GetButton("Jump");
        float LookHorizontal = Input.GetAxisRaw("Controller X");
        

        transform.Rotate(0f,LookHorizontal, 0f, Space.Self);

       
        if (controller.isGrounded)
            { if (Jump){
                VertiavlVerlocity = jumpForce;
            }
        }
            else
            {
                VertiavlVerlocity -= gravity * Time.deltaTime;
            }
            Vector3 jumpVector = new Vector3(0, VertiavlVerlocity, 0);
            controller.Move(jumpVector * Time.deltaTime);
        
        

        if (Sprint)
        {
            transform.Translate(Horizintal * Time.deltaTime * 20, 0f, 0f);
            transform.Translate(0f, 0f, Vertical * Time.deltaTime * 20);
        }
        else
        {
            transform.Translate(Horizintal * Time.deltaTime*10, 0f, 0f);
            transform.Translate(0f, 0f, Vertical * Time.deltaTime*10);
        }
    }

  
}
