using UnityEngine;

public class Eaten : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mouth")
        {
            Destroy(gameObject);
            Vector3 rotationInDeg = transform.eulerAngles;
            rotationInDeg.x += adjustmentAngle;
            Quaternion rotationInRad = Quaternion.Euler(rotationInDeg);

            Instantiate(prefabToSpawn, transform.position, rotationInRad);
            Debug.Log("nom nom nom");
        }
    }
}
