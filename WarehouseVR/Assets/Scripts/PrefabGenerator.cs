using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public float timer;
    public GameObject boxPrefab;
    public float nextTime = 10.999991f;

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        
        if (timer >= nextTime )
        {
          Instantiate(boxPrefab, new Vector3(0, 5.22f, -3.447f), Quaternion.identity);
          nextTime += 10.999991f;
        }
    }
}
