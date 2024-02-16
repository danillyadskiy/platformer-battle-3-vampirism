using System;
using System.Collections;
using UnityEngine;

public class VampirismSpell : MonoBehaviour
{
    private readonly float _healthPerSecond = 20f;
    private readonly WaitForSeconds _workingTimeInSeconds = new WaitForSeconds(6);
    
    [SerializeField] private Player _player;
    
    private bool _isActive = false;
    
    public void OnTriggerStay2D(Collider2D other)
    {
        if (_player.IsAlive)
        {
            if (_isActive)
            {
                if (other.TryGetComponent(out Enemy enemy))
                {
                    float health = _healthPerSecond * Time.deltaTime;
                    enemy.GetDamage(health);
                    _player.RestoreHealth(health);
                }
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Work());
        }
    }

    private IEnumerator Work()
    {
        _isActive = true;

        yield return _workingTimeInSeconds;

        _isActive = false;
    }
}
