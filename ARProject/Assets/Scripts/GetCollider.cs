using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetCollider : MonoBehaviour
{
    int humanCount;
    public TMP_Text humanCountText;
    public bool canGetHuman;

    void Update()
    {
        HumanCheck();
        humanCountText.text = "Humans: " + humanCount;
    }

    //Уничтожение объекта человека и добавление к количеству
    private void OnTriggerEnter(Collider other)
    {
        if (canGetHuman)
        {
            if (other.gameObject.tag == "Interactable")
            {
                humanCount++;
                Destroy(other.gameObject);
            }
        }
        else
        {
            return;
        }
    }

    //Проверка на количество людей
    public void HumanCheck()
    {
        if (humanCount >= 1)
        {
            canGetHuman = false;
        }
        else
        {
            canGetHuman = true;
        }
    }
}
