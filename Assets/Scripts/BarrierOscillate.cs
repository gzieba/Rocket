﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierOscillate : MonoBehaviour
{
    private Vector3 initalPosition;
    [SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 0.0f);
    [SerializeField] float period = 2f;
    [SerializeField] float movementOffset = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        initalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; } // protect against period is zero
        float cycles = Time.time / period; // grows continually from 0

        const float tau = Mathf.PI * 2f; // about 6.28
        float rawSinWave = Mathf.Sin(cycles * tau); // goes from -1 to +1

        float movementFactor = rawSinWave / 2f + movementOffset;
        Vector3 offset = movementFactor * movementVector;
        transform.position = initalPosition + offset;
    }
}
