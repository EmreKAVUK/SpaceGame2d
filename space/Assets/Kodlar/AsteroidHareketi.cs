﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHareketi : MonoBehaviour
{
    Rigidbody fizik;
    public float hız;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * hız;
    }

}