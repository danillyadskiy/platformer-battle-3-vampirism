using System;
using UnityEngine;

public class  Bag : MonoBehaviour
{
    public int Coins { get; private set; }
    
    public event Action AmountChanged;
    
    public void AddCoin()
    {
        Coins++;
        AmountChanged?.Invoke();
    }
}
