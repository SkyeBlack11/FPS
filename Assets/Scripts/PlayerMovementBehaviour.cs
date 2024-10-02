using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float _movementSpeed, _rotationSpeed;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movementDirection = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            movementDirection += new Vector3(0, 0, 1); //Forward
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDirection += new Vector3(-1, 0, 0); //Left
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementDirection += new Vector3(0, 0, -1); //Backward
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementDirection += new Vector3(1, 0, 0); //Right
        }

        transform.position += 
            (movementDirection.z * transform.forward +
            movementDirection.x * transform.right) *
            _movementSpeed * Time.deltaTime;        
    }

    void Update()
    {
        Vector3 rotation = Vector3.zero;
        rotation.y = Input.GetAxis("Mouse X"); //because unity's mouse x axis is actually our regular y and vice versa.
        transform.Rotate(rotation * Time.deltaTime * _rotationSpeed);

    }
}
