using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 1);
        transform.position +=
            (movement.z * transform.forward +
            movement.x * transform.right) *
            _speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor" || collision.gameObject.tag != "Player")
        {
            transform.Rotate(0, 90f, 0);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        //transform.Rotate(0, 0, 0);
    }
}
