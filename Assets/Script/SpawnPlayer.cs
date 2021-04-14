using System;
using System.Collections;
using System.Collections.Generic;
using ScoredProductions.Global;
using ScoredProductions.PGDC;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
   [SerializeField] private GameObject playerBody;
   [SerializeField] private GameObject destroybody;
    private void OnCollisionEnter(Collision other)
   {  
      
      if (other.gameObject.CompareTag("Player"))
      {  
         Destroy(destroybody); 
       //  Instantiate(playerBody, transform.position, Quaternion.identity);
      }
   }
}
