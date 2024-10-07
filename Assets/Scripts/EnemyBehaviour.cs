using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _currenthealth;
    void Start()
    {
        _currenthealth = _maxHealth;
    }

    public void Hit()
    {
        _currenthealth -= 1;
        if(_currenthealth <= 0)
        {
            transform.Rotate(-75f, 0, 0);
        }

    }
    void Update()
    {
        
    }
}
