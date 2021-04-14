using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class GameObjectDestoyer : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }

  
}
