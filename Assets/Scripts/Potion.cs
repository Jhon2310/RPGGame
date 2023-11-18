using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
   [SerializeField] private float _outlineWidth = 2f;
   [SerializeField] private Outline _outlinePlayer;

   

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         _outlinePlayer.OutlineWidth = _outlineWidth;
         Destroy(this.gameObject);
      }
   }
}
