using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestructionOfTheBridge : MonoBehaviour
{
    [SerializeField]
    private Bridge _bridge;
    
   
    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<NavMeshAgent>();
        if (player != null)
        {
            var outline = player.GetComponent<Outline>();
            if (outline.OutlineWidth <= 0)
            {
                _bridge.Break();
            }
            
        }
    }
    
}
