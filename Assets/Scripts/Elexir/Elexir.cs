using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Elexir : MonoBehaviour
{
    private int _healing = 2;

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.TryGetComponent<Player>(out Player player))
        {
            if (player.CurrentHealth <= 8)
            {
                player.AddHealth(_healing);
                Destroy(gameObject);
            }
        }
    }
}
