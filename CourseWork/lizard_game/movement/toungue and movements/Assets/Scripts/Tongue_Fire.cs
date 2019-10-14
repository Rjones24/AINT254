using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue_Fire : MonoBehaviour
{

    public GameObject Tongue;
    public Transform Spawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }

    private void Fire()
    {
        isFiring = true;
        Instantiate(Tongue, Spawn.position, Spawn.rotation);

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        Invoke("SetFiring", fireTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Fire1")>0)
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }
}
