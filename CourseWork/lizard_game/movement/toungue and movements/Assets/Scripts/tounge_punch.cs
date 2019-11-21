using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tounge_punch : MonoBehaviour
{
    public GameObject Tongue;
    public Transform Spawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;
    public int damage = 10;

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

    void Update()
    {
        if (Input.GetAxisRaw("Fire2") > 0)
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
    }
}
