using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{

    // 当たり判定内に他オブジェクトが侵入した際呼び出されるメソッド
    // 引数:接触オブジェクトしたオブジェクトのCollider情報
    void OnTriggerEnter2D(Collider2D collider)
    {
        // 弾とボスオブジェクトを消滅させる
        Destroy(collider.gameObject);   // 弾オブジェクト消去
        Destroy(gameObject);            // 自オブジェクト消去
    }
}
