using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearPoint : MonoBehaviour
{
    public int clearpoint = 0;
    public Text textClearPoint;

    void Start()
    {
        //�|�C���g�l�̃��[�h
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // ���j���[��ʕ\���p
        textClearPoint.text = "" + clearpoint;

        Debug.Log("�N���A�|�C���g���[�h");
    }


    public void OnClickStartButton()
    {
        SceneManager.LoadScene("main");

        clearpoint += 1;
        AddPoint();
    }


    //�|�C���g�����------------------------------------------
    void AddPoint()
    {
        textClearPoint.text = clearpoint + "";

        //�|�C���g�l�̃Z�[�u
        ES3.Save<int>("Clearkey", clearpoint);

        Debug.Log("�N���A�|�C���g�l��");
    }


}
