using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOwer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private SpawnerCoin _spawnerCoin;
    [SerializeField] private UnityEvent _stopGame;

    private void OnEnable()
    {
        _player.ManeyCountChanged += OnVCoinChanged;
        _player.OnDied += DiedPlayer;
    }

    private void OnVCoinChanged(int value)
    {
        if (_spawnerCoin.CoinCount < value)
        {
            _stopGame?.Invoke();
        }
    }

    private void DiedPlayer()
    {
        _stopGame?.Invoke();
    }

    private void OnDisable()
    {
        _player.ManeyCountChanged -= OnVCoinChanged;
        _player.OnDied -= DiedPlayer;
    }
}
