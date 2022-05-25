using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DinamiteBar : MonoBehaviour
{
    [SerializeField] private TMP_Text _TextBar;
    [SerializeField] private Player _player;


    private void OnEnable()
    {
        _player.DinamiteCountChanged += OnValueChanged;
        _TextBar.text = _player.Dinamite.ToString();
    }

    private void OnValueChanged()
    {
        _TextBar.text = _player.Dinamite.ToString();
    }

    private void OnDisable()
    {
        _player.DinamiteCountChanged -= OnValueChanged;
    }
}
