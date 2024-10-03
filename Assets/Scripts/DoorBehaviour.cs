using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    [SerializeField] private KeyBehaviour _keyForDoor;
    private bool _playerInRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_playerInRange) return;

        
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (KeyBehaviour key in PlayerController.Instance.KeysCollected)
            {
                if(key == _keyForDoor)
                {
                   Destroy(gameObject);
                    return;
                }
               
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        _playerInRange = true;
        //Debug.Log("Ouch");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        _playerInRange = false;
    }
}
