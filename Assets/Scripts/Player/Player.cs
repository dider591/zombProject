using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _dinamiteCount;

    public int Maney { get; private set; }
    public int Health { get; private set; }
    public int Dinamite => _dinamiteCount;


    private int _currentHealth;

    public int CurrentHealth => _currentHealth;

    public event UnityAction<int, int> HealthChanged;
    public event UnityAction<int> ManeyCountChanged;
    public event UnityAction DinamiteCountChanged;
    public event UnityAction OnDied;

    private void Start()
    {
        Health = 10;
        _currentHealth = Health;
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        HealthChanged?.Invoke(_currentHealth, Health);

        if (_currentHealth <= 0)
        {
            OnDied.Invoke();
        }
    }

    public void AddHealth(int health)
    {
        _currentHealth += health;
        HealthChanged?.Invoke(_currentHealth, Health);
    }

    public void AddManey(int maney)
    {
        Maney += maney;
        ManeyCountChanged?.Invoke(Maney);
    }

    public void DinamiteChanged()
    {
        _dinamiteCount--;
        DinamiteCountChanged?.Invoke();
    }
}
