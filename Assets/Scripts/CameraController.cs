using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _playerCapsule;
    [SerializeField] private float _minVerticalRotation, _maxVerticalRotation;
    [SerializeField] private float _rotationSensitivity;
    private Vector3 _horizonalRotation, _verticalRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        _horizonalRotation.y += Input.GetAxis("Mouse X") * Time.deltaTime * _rotationSensitivity; //because unity's mouse x axis is actually our regular y and vice versa.
        _verticalRotation.x += -Input.GetAxis("Mouse Y") * Time.deltaTime * _rotationSensitivity; // Up and Down!
        _verticalRotation.x = Mathf.Clamp(_verticalRotation.x, _minVerticalRotation, _maxVerticalRotation);

        _playerCapsule.transform.eulerAngles = _horizonalRotation;
        transform.eulerAngles = new Vector3(_verticalRotation.x, transform.eulerAngles.y);

    }
}
