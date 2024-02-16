using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected HealthModel Health;

    public bool IsAlive { get; private set; } = true;
    
    public event Action Dead;

    public void GetDamage(float damage)
    {
        Health.Decrease(damage);

        if (Health.Value <= 0)
        {
            IsAlive = false;
            Dead?.Invoke();
        }
    }
}
