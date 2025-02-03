using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShelfCheck : MonoBehaviour
{
    public int objectsCount;
    public TMP_Text objectsCountText;
    public BoxCollider thisBoxCollider;

    private void Update()
    {
        objectsCountText.text = objectsCount.ToString();

        if (objectsCount == 3)
        {
            CheckShelfComplete();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Проверка на тэг объекта
        if (other.gameObject.tag == "actionObject")
        {
            objectsCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Проверка на тэг объекта
        if (other.gameObject.tag == "actionObject")
        {
            if (objectsCount > 0)
            {
                objectsCount--;
            }
        }
    }

    //Проверка на зполненность стеллажа
    public void CheckShelfComplete()
    {
        GameManager.instance.completeShelfsCount++;
        Debug.Log("Completed: " + GameManager.instance.completeShelfsCount.ToString());
        objectsCount = 0;
        objectsCountText.color = Color.green;
    }
}
