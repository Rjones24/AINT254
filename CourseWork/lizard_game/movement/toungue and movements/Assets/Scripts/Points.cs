using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         for (int i = 0; i < 5; i++)
        {
           transform.Translate(0f, 0.1f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
