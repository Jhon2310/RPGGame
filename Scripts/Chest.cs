using System;
using UnityEngine;
using UnityEngine.AI;

public class Chest : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Open1 = Animator.StringToHash("open");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    
    public void Open()
    {
       
        _animator.SetTrigger(Open1);
    }
}