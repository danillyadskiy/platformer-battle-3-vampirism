using System;
using UnityEngine;

public class HealthModel : MonoBehaviour
{
    public event Action Changed;
    
    public float MinValue => 0f;
    public float MaxValue => 100f;

    public float Value { get; private set; } = 100f;
    
    public float RelativeValue => Value / MaxValue;

    public void Increase(float value)
    {
        Value += value;
        ChangeValue();
    }

    public void Decrease(float value)
    {
        Value -= value;
        ChangeValue();
    }

    private void ChangeValue()
    {
        Value = Mathf.Clamp(Value, MinValue, MaxValue);
        Changed?.Invoke();
    }
}
