using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 8f;
    public float movableRange = 5.5f;
    public float power = 1000f;
    public GameObject cannonBall;
    public Transform spawnPoint;

    void Update()
    {

        transform.position = new Vector2(
Mathf.Clamp(transform.position.x, -movableRange, movableRange),
            transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        




            //キャラのy軸のdirection方向にscrollの力をかける
            rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

            //ジャンプ判定
            if (Input.GetKeyDown("w") && !jump)
            {
                rb2d.AddForce(Vector2.up * flap);
                jump = true;
            }


        
    }


    void Shoot()
    {
        GameObject newBullet = Instantiate(
            cannonBall,
            spawnPoint.position,
            Quaternion.identity) as GameObject;
        newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.right * power);
    }



    //変数定義
    public float flap = 1000f;
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;

    // Use this for initialization
    void Start()
    {
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump
                = false;
        }
    }
    }
