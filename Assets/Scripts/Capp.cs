﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capp : MonoBehaviour {
    void Update()
    {
        transform.Rotate(new Vector3(100, 100, 100) * Time.deltaTime);



    }
}
