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

    void Start()
    {
        //ポイント値のロード
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // メニュー画面表示用
        textClearPoint.text = "" + clearpoint;

        Debug.Log("クリアポイントロード");

        ClearButton();
    }


    public void OnClickStartButton()
    {
        //SceneManager.LoadScene("main");

        clearpoint += 1;
        AddPoint();
    }

    public void OnClickStartButtonNormal()
    {
        SceneManager.LoadScene("main");

        clearpoint += 1;
        AddPoint();
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

}
