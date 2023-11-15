using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    [SerializeField] private Bridge _bridge;
    [SerializeField] private Outline _playerOutline;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && _playerOutline.OutlineWidth == 0 )
        {
            _bridge.Break();
        }
    }
}
