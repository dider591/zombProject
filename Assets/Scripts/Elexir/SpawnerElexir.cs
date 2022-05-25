using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerElexir : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Elexir _elexir;

    private void Start()
    {
        foreach (var point in _spawnPoints)
        {
            Instantiate(_elexir, point.position, point.rotation, point);
        }
    }
}
