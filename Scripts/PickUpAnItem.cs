using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PickUpAnItem : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        var player = other.gameObject.GetComponent<NavMeshAgent>();
        if ( player != null)
        {
            var outline = player.GetComponent<Outline>();
            outline.OutlineWidth = 2;
            Destroy(gameObject);
        }
    }
}
