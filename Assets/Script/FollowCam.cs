using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class FollowCam : MonoBehaviour
{
    [SerializeField] private Transform player;
    
    // Update is called once per frame
    void Update()
    {   
        if (player != null)
        {
            var Position = player.position;
            transform.position = new Vector3(0, 4.86f, Position.z - 4.5f);
        }
        

    } 
    
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }




}