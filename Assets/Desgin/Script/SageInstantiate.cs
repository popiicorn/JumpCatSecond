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
        //Instantiate(stageprefab[1]);

        //�|�C���g�l�̃��[�h
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // ���j���[��ʕ\���p
        textClearPoint.text = "stage" + clearpoint;

        // �X�e�[�W�����[�h
        RoadStage();

        Debug.Log("�N���A�|�C���g���[�h");
    }




    // ���[�h�X�e�[�W
    void RoadStage()
    {
        if (clearpoint == 0)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[0]);
            }
        }

        if (clearpoint == 1)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[1]);
            }
        }

        if (clearpoint == 2)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[2]);
            }
        }

        if (clearpoint == 3)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[3]);
            }
        }

        if (clearpoint == 4)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[4]);
            }
        }

        if (clearpoint == 5)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[5]);
            }
        }

        if (clearpoint == 6)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[6]);
            }
        }

        if (clearpoint == 7)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[7]);
            }
        }
    }
}
