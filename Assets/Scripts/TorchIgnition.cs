using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchIgnition : MonoBehaviour
{
    public event Action LightTheTorch;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LightTheTorch?.Invoke();
        }
    }

    
}
