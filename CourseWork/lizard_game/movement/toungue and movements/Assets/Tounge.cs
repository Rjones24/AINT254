using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tounge : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnBecameInvisible()
    {
        Die();
    }


    private void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
