﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    private Vector3 offset = new Vector3(0, 4, -10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set the camera to the player's position and offset it above the vehicle.
        transform.position = player.transform.position + offset;
    }
}
