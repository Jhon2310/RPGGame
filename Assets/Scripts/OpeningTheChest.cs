using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningTheChest : MonoBehaviour
{
    public event Action OpenTheChest;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenTheChest?.Invoke();
        }
    }
}
