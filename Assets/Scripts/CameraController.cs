using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _playerCapsule;
    [SerializeField] private float _minVerticalRotation, _maxVerticalRotation;
    [SerializeField] private float _rotationSensitivity, _maxRotationPerFrame;
    private Vector3 _horizonalRotation, _verticalRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontalDelta = new Vector3(
            0, Input.GetAxis("Mouse X") * Time.deltaTime * _rotationSensitivity); //because unity's mouse x axis is actually our regular y and vice versa.
        Vector3 verticalDelta = new Vector3(
            -Input.GetAxis("Mouse Y") * Time.deltaTime * _rotationSensitivity, 0);
        
        _horizonalRotation += Vector3.ClampMagnitude(horizontalDelta, _maxRotationPerFrame);
        _verticalRotation += Vector3.ClampMagnitude(verticalDelta, _maxRotationPerFrame);

        _verticalRotation.x = Mathf.Clamp(_verticalRotation.x, _minVerticalRotation, _maxVerticalRotation);

        _playerCapsule.transform.eulerAngles = _horizonalRotation;
        transform.eulerAngles = new Vector3(_verticalRotation.x, transform.eulerAngles.y);

    }
}
