using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                FireWeapon(hit);
            }

        }
    }

    void FireWeapon(RaycastHit hit)
    {
        GameObject projectile = Instantiate(_projectilePrefab);
        projectile.transform.position = hit.point;
        projectile.transform.parent = hit.transform;
        if(hit.transform.tag == "Enemy")
        {
            hit.transform.GetComponent<EnemyBehaviour>().Hit();
        }
    }
}
