using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : CharacterBehaviour
{
    public override void Die()
    {
        transform.Rotate(-75f, 0, 0);
        GetComponent<EnemyWeaponBehaviour>().enabled = false;
        GetComponent<EnemyMovementBehaviour>().enabled = false;
    }

    void Update()
    {
        if (GetComponent<EnemyWeaponBehaviour>().enabled == false) return;
    
    }
}
