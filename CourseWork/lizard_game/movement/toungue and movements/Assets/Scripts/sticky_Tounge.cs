using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky_Tounge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
       
            if (collision.gameObject.GetComponent<Rigidbody>() != null)
            {
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
            }
    }

  
}
