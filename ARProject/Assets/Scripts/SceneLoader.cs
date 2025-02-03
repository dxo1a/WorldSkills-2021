using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Загрузка уровня
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    //Выход из игры
    public void Exit()
    {
        this.Exit();
    }
}
