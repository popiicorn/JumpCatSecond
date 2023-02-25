using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearPoint : MonoBehaviour
{
    public int clearpoint = 0;
    public Text textClearPoint;

    public GameObject normalButton;
    public GameObject insteButton;

    public GameObject normalTitle;
    public GameObject lastTitle;

    void Start()
    {
        //ポイント値のロード
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // メニュー画面表示用
        textClearPoint.text = "" + clearpoint;

        Debug.Log("クリアポイントロード");

        ClearButton();
        ClearTitle();
    }


    public void OnClickStartButton()
    {
        //SceneManager.LoadScene("main");

        clearpoint += 1;
        AddPoint();
        LastPoint();
    }

    public void OnClickStartButtonNormal()
    {
        SceneManager.LoadScene("main");

        clearpoint += 1;
        AddPoint();
        LastPoint();
    }


    //ポイント数代入------------------------------------------
    void AddPoint()
    {
        textClearPoint.text = clearpoint + "";

        //ポイント値のセーブ
        ES3.Save<int>("Clearkey", clearpoint);

        Debug.Log("クリアポイント獲得");
    }


    // 広告ボタン------------------------------------------
    void ClearButton()
    {
        if (clearpoint <= 5)
        {
            normalButton.SetActive(true);
            insteButton.SetActive(false);
        }
        else
        {
            normalButton.SetActive(false);
            insteButton.SetActive(true);
        }
    }

    //ラストポイント数代入------------------------------------------
    void LastPoint()
    {
        textClearPoint.text = clearpoint + "";

        if (clearpoint == 61)　//最後のステージ数+1を記入(最後のステージが2なら3)
        {
            clearpoint = 0;
        }

        //ポイント値のセーブ
        ES3.Save<int>("Clearkey", clearpoint);

        Debug.Log("ラストクリアポイント獲得");
    }

    // クリア画面------------------------------------------
    void ClearTitle()
    {
        if (clearpoint < 60)　//最後のステージ数を記入(最後のステージが2なら2)
        {
            normalTitle.SetActive(true);
            lastTitle.SetActive(false);
        }
        else
        {
            normalTitle.SetActive(false);
            lastTitle.SetActive(true);
        }
    }

}
