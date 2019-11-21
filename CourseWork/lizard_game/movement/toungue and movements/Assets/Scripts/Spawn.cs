using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;


    public void Spawner()
    {
        Vector3 rotationInDeg = transform.eulerAngles;
        rotationInDeg.x += adjustmentAngle;
        Quaternion rotationInRad = Quaternion.Euler(rotationInDeg);

        Instantiate(prefabToSpawn, transform.position, rotationInRad);
    }

}
