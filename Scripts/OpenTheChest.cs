using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpenTheChest : MonoBehaviour
{
    [SerializeField]
   private Chest _chest;




   private void OnTriggerEnter(Collider other)
    {
        
       
        if (other.gameObject.GetComponent<NavMeshAgent>() != null)
        {
            _chest.Open();
        }
    }

   
}
