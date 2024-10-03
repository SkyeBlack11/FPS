using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        PlayerController.Instance.KeysCollected.Add(this);
        //Debug.Log("I got a Key!");
        gameObject.SetActive(false);
    }
}
