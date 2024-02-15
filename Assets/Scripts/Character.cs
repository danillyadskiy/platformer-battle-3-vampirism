using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public event Action Dead;
    
    [SerializeField] protected HealthModel Health;

    public bool IsAlive { get; private set; } = true;

    public void GetDamage(int damage)
    {
        Health.Decrease(damage);

        if (Health.Value <= 0)
        {
            IsAlive = false;
            Dead?.Invoke();
        }
    }
}
