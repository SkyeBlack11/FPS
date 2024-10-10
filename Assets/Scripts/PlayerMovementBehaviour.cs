using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Rigidbody _rigidBody;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
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
        movementDirection = Vector3.ClampMagnitude(movementDirection, 1);
        Vector3 velocity = (movementDirection.z * transform.forward + movementDirection.x * transform.right) *_movementSpeed;
        _rigidBody.velocity = velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "EndPoint")
        {
            Debug.Log("Finish!");
        }
        
    }

    void Update()
    {

    }
}
