using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoFlushHour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MyTime time = new MyTime();
        if (cacheMinute_ == time.GetMinute())
        {
            return;
        }
        cacheMinute_ = time.GetMinute();
        float angle = ((time.GetHour() % 12) * 30f + time.GetMinute() * 0.5f) - 90f;
        transform.eulerAngles = new Vector3(angle, 0, 0);
        
    }

    private int cacheMinute_ = -1;
}
