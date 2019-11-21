using UnityEngine;

public class Player : MonoBehaviour
{

    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;

    public void SendHealthData(int Health)
    {
        if (OnUpdateHealth != null)
        {
            OnUpdateHealth(Health);
        }
    }
}

