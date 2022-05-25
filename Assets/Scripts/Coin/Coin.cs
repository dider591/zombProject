using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _reward;

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.TryGetComponent<Player>(out Player player))
        {
            player.AddManey(_reward);
            Destroy(gameObject);
        }
    }
}
