using UnityEngine;
using System.Collections;

public class BackGroundController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -18.8f)
        {
            transform.position = new Vector3(18.8f, 0, 0);
        }
    }
}