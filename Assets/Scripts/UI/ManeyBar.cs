using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManeyBar : MonoBehaviour
{
    [SerializeField] private TMP_Text _TextBar;
    [SerializeField] private Player _player;


    private void OnEnable()
    {
        _player.ManeyCountChanged += OnValueChanged;
        _TextBar.text = 0.ToString();
    }

    private void OnValueChanged(int maney)
    {
        _TextBar.text = maney.ToString();
    }

    private void OnDisable()
    {
        _player.ManeyCountChanged -= OnValueChanged;
    }
}
