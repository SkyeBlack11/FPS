using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public List<KeyBehaviour> KeysCollected;
    void Start()
    {
        Instance = this; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
