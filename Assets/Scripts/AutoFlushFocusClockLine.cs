using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFlushFocusClockLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyTime time = new MyTime();
        lastTime_ = new DateTime(1, 1, 1, time.GetHour(), time.GetMinute(), time.GetSecond());
        now_ = lastTime_;
        float angle = ((time.GetHour() % 12) * 30f + time.GetMinute() * 0.5f) - 90f;
        transform.eulerAngles = new Vector3(angle + PanelSave.FocusMinutes * 0.5f, 0, 0);
        targetTime_ = lastTime_.AddMinutes(PanelSave.FocusMinutes);
    }

    // Update is called once per frame
    void Update()
    {
        MyTime time = new MyTime();
        now_ = now_.AddSeconds(Time.deltaTime * PanelSave.TimeSpeed);
        if (now_ < targetTime_)
        {
            return;
        }
        
        lastTime_ = targetTime_;
        targetTime_ = lastTime_.AddMinutes(PanelSave.FocusMinutes + PanelSave.BreakMinutes);
        transform.Rotate((PanelSave.FocusMinutes + PanelSave.BreakMinutes) * 0.5f, 0, 0, Space.Self);
    }

    private DateTime lastTime_;
    private DateTime targetTime_;
    private DateTime now_;
}
