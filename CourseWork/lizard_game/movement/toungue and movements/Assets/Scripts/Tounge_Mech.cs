using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tounge_Mech : MonoBehaviour
{
    public float moveSpeed;
   
    int Distance = 15;
    int CurrentDistance = 0;
    bool HitLimit = false;
 

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (HitLimit == false)
        {
            transform.Translate(0f, 0f, moveSpeed);
            CurrentDistance += 1;
        }
        else if (HitLimit == true)
        {
            transform.Translate(0f, 0f, -moveSpeed);
            CurrentDistance -= 1;
        }

    if (CurrentDistance > Distance)
        {
            
            HitLimit = true;
        }
        else if (CurrentDistance == 0)
        {
            Die();
        }
      
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
           
                HitLimit = true;
        }
        
    }
}
