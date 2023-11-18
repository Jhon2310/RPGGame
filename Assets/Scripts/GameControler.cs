using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    [SerializeField] private OpeningTheChest _openingTheChest;
    [SerializeField] private Chest _chest;
    [SerializeField] private DestructionOfTheBridge _destructionOfTheBridge;
    [SerializeField] private Bridge _bridge;
    [SerializeField] private TorchIgnition _torchIgnition;
    [SerializeField] private Torch _fire;

    private void Awake()
    {
        _openingTheChest.OpenTheChest += _chest.Open;
        _destructionOfTheBridge.DestroyTheBridge += _bridge.Break;
        _torchIgnition.LightTheTorch += _fire.LightTheTorch;

    }

    private void OnDisable()
    {
        _openingTheChest.OpenTheChest -= _chest.Open;
        _destructionOfTheBridge.DestroyTheBridge -= _bridge.Break;
        _torchIgnition.LightTheTorch += _fire.LightTheTorch;
    }
}
