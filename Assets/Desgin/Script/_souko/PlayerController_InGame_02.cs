using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController_InGame_02 : MonoBehaviour
{

    Rigidbody2D rigid2D;
    float jumpForce = 780.0f;
   

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // ジャンプする
        if (Input.GetMouseButtonDown(0))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }





        // 画面外に出た場合は最初から
        if (transform.position.y < -30)
        {
            SceneManager.LoadScene("InGame_02");
        }

    }

    // ゴールに到達
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ゴール");
        SceneManager.LoadScene("Clear_InGame_02");
    }
}