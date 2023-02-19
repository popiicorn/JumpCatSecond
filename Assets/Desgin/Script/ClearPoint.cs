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
        //�|�C���g�l�̃��[�h
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // ���j���[��ʕ\���p
        textClearPoint.text = "" + clearpoint;

        Debug.Log("�N���A�|�C���g���[�h");

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

    //���X�g�|�C���g�����------------------------------------------
    void LastPoint()
    {
        textClearPoint.text = clearpoint + "";

        if (clearpoint == 51)�@//�Ō�̃X�e�[�W��+1���L��(�Ō�̃X�e�[�W��2�Ȃ�3)
        {
            clearpoint = 0;
        }

        //�|�C���g�l�̃Z�[�u
        ES3.Save<int>("Clearkey", clearpoint);

        Debug.Log("���X�g�N���A�|�C���g�l��");
    }

    // �N���A���------------------------------------------
    void ClearTitle()
    {
        if (clearpoint < 50)�@//�Ō�̃X�e�[�W�����L��(�Ō�̃X�e�[�W��2�Ȃ�2)
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
