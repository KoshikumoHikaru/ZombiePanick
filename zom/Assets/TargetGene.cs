using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGene : MonoBehaviour
{
    private Vector3 targetpos;
    void Start()
    {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 16.0f + targetpos.x, targetpos.y,targetpos.x);
    }
}
