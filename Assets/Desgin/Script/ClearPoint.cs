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
        //�|�C���g�l�̃��[�h
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // ���j���[��ʕ\���p
        textClearPoint.text = "" + clearpoint;

        Debug.Log("�N���A�|�C���g���[�h");

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


    //�|�C���g�����------------------------------------------
    void AddPoint()
    {
        textClearPoint.text = clearpoint + "";

        //�|�C���g�l�̃Z�[�u
        ES3.Save<int>("Clearkey", clearpoint);

        Debug.Log("�N���A�|�C���g�l��");
    }


    // �L���{�^��------------------------------------------
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
