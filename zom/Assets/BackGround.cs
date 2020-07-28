using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -19f)
        {
            transform.position = new Vector3(19f, -4.35f, 0);
        }
    }
}