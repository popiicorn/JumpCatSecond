using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageInstantiate : MonoBehaviour
{
    public GameObject[] stageprefab;
    public int clearpoint = 0;
    public Text textClearPoint;


    // Start is called before the first frame update
    void Start()
    {

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
        if (clearpoint == clearpoint * 1)
        {
            for (int count = 0; count < 1; count++)
            {
                Instantiate(stageprefab[clearpoint]);
            }
        }
    }


}
