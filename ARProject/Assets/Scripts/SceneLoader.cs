using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //�������� ������
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    //����� �� ����
    public void Exit()
    {
        this.Exit();
    }
}
