using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private GameObject _fire;

    private void OnTriggerExit(Collider other)
    {
        var player = other.gameObject.GetComponent<NavMeshAgent>();
        if (player != null)
        {
            _fire.SetActive(true);
            
        }
    }
}
