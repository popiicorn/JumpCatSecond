using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton_InGame_02 : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("InGame_02");
    }
}
