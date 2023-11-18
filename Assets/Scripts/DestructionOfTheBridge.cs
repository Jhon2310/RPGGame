using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfTheBridge : MonoBehaviour
{
    public event Action DestroyTheBridge;
    
    [SerializeField] private float _outlineWidth = 2f;
    [SerializeField] private Outline _outlinePlayer;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _outlinePlayer.OutlineWidth!=_outlineWidth)
        {
            DestroyTheBridge?.Invoke();
        }
    }
}
