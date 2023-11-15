using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private Outline _playerOutline;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerOutline.OutlineWidth = 2;
            Destroy(_gameObject);
        }
    }
}
