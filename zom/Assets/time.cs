﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class time : MonoBehaviour
{

    float countTime = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F2");

    }
}

