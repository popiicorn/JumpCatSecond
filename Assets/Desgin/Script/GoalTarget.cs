using UnityEngine;
using System.Collections;

public class GoalTarget : MonoBehaviour
{
    public  GameObject lookTarget;

   
    void Update()
    {


        {
            // �Ώە��ւ̃x�N�g�����Z�o
            Vector3 toDirection = lookTarget.transform.position - transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.LookRotation(toDirection, Vector3.forward);
        }
    }
}