  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speed = 1f; 


    // Start is called before the first frame update
    void Start()
    {
        
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

        if (Jump)
        {
            transform.Translate(0f, Time.deltaTime * 4, 0f);
        }

        if (Sprint)
        {
            transform.Translate(Horizintal * Time.deltaTime * 2, 0f, 0f);
            transform.Translate(0f, 0f, Vertical * Time.deltaTime * 2);
        }
        else
        {
            transform.Translate(Horizintal * Time.deltaTime, 0f, 0f);
            transform.Translate(0f, 0f, Vertical * Time.deltaTime);
        }
    }
}
