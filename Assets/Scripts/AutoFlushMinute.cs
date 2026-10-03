using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFlushMinute : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyTime time = new MyTime();
        if (cacheSecond_ == time.GetSecond())
        {
            return;
        }
        cacheSecond_ = time.GetSecond();
        float angle = time.GetMinute() * 6f + time.GetSecond() * 0.1f - 90f;
        transform.eulerAngles = new Vector3(angle, 0, 0);
    }

    private int cacheSecond_ = -1;
}
