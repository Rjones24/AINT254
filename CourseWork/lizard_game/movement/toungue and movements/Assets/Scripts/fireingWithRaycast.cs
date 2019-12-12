using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireingWithRaycast : MonoBehaviour
{
    public int toungeDamage = 10;
    public float rateOfFire = 5.0f;
    private Camera camera;
    Vector3 rayOrigin = Vector3.zero;
    public Transform Mouth;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Fire2") > 0)
        {
           
            Vector3 rayOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit hit;

            if (Physics.Raycast(rayOrigin, camera.transform.forward, out hit, 25))
            {
                
                Debug.DrawLine(rayOrigin, hit.point, Color.red);
            }
        }

    
    }
}
