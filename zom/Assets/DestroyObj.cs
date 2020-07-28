using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float deletetime = 2.0f;

    void Start()
    {
        Destroy(gameObject, deletetime);
    }
}
