using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : CharacterBehaviour
{
    public static PlayerController Instance;
    public List<KeyBehaviour> KeysCollected;
    [SerializeField] private GameObject _failureWindow;
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        _healthText.text = "Health: " + _currentHealth + "/" + _maxHealth;
    }

    public override void Die()
    {
        _failureWindow.SetActive(true);
        GetComponent<PlayerMovementBehaviour>().enabled = false;
        GetComponent<PlayerWeaponBehaviour>().enabled = false;
        GetComponentInChildren<CameraController>().enabled = false;
    }

    

}
