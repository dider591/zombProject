using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healhBar;
    [SerializeField] private Player _player;


    private void OnEnable()
    {
        _player.HealthChanged += OnValueChanged;
        _healhBar.value = 1;
    }

    private void OnValueChanged(int value, int maxValue)
    {
        _healhBar.value = (float)value / maxValue;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnValueChanged;
    }
}
