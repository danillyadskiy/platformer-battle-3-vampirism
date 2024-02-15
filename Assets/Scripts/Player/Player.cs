using System;
using UnityEngine;

public class Player : Character
{
    public void RestoreHealth()
    {
        Health.Increase(Health.MaxValue);
    }

    public void RestoreHealth(float health)
    {
        Health.Increase(health);
    }
}
