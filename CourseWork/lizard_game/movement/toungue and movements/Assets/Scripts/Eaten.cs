using UnityEngine;

public class Eaten : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mouth")
        {
            Destroy(gameObject);

            Debug.Log("nom nom nom");
        }
    }
}
