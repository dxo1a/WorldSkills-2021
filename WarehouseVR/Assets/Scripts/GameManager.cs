using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //�������� Singleton
    public static GameManager instance { get; private set; }

    public int completeShelfsCount;
    public TMP_Text completeShelfCountText;
    public GameObject MenuUIObject;

    //�������� Singleton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }

        Destroy(this.gameObject);
    }

    private void Start()
    {
        MenuUIObject.SetActive(false);
    }

    private void Update()
    {
        completeShelfCountText.text = "����������� ��������: " + completeShelfsCount.ToString();
        CheckShelfs();
    }

    public void CheckShelfs()
    {
        if (completeShelfsCount == 4)
        {
            Debug.Log("You win!");
            MenuUIObject.SetActive(true);
        }
        if (completeShelfsCount > 4)
        {
            completeShelfsCount = 4;
        }
    }

    //������� ����
    public void RestartTheGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    //����� �� ����
    public void ExitTheGame()
    {
        Application.Quit();
    }
}
