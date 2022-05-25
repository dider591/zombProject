using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnerCoin : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Coin _coin;

    public int CoinCount => _spawnPoints.Count;

    private void Start()
    {
        foreach (var point in _spawnPoints)
        {
            Instantiate(_coin, point.position, point.rotation, point);
        }
    }

}
