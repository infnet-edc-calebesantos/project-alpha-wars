﻿using UnityEngine;

public class BaseManager : MonoBehaviour
{
    public bool Busy { get; private set; }

    void Start()
    {
        Busy = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Busy");
    }
}
