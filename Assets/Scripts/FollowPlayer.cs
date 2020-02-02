using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    [SerializeField] Vector3 offset = new Vector3(0, 4, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        // Set the camera to the player's position and offset it above the vehicle.
        transform.position = player.transform.position + offset;
    }
}
