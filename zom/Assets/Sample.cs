using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sample : MonoBehaviour
{
    /// <summary>
    /// 速度[m/s]
    /// </summary>
    private Vector3 _velocity = new Vector3(-10, 0, 0);

    void Update()
    {
        // position[m] = position[m] + (velocity[m/s] * time[s])
        // [m] = [m] + [(m/s * s)]
        // [m] = [m] + [m]  ←両辺で単位が同じになった
        transform.position = transform.position + (_velocity * Time.deltaTime);
    }


    public float deletetime = 2.0f;

void Start()
{
    Destroy(gameObject, deletetime);
}
}