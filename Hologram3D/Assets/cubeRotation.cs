﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.up, 3.0f);
        //Debug.Log("rotating..."); 
    }
}
