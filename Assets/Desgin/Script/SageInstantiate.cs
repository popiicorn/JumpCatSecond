using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SageInstantiate : MonoBehaviour
{
    public GameObject[] stageprefab;
    public int clearpoint = 0;
    public Text textClearPoint;


    // Start is called before the first frame update
    void Start()
    {

        //ポイント値のロード
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // メニュー画面表示用
        textClearPoint.text = "stage" + clearpoint;

        // ステージをロード
        RoadStage();

        Debug.Log("クリアポイントロード");
    }




    // ロードステージ
    void RoadStage()
    {
        if (clearpoint == clearpoint)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[clearpoint]);
            }
        }
    }
}
