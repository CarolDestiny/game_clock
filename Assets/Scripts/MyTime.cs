
using System;
using UnityEngine;

public class MyTime
{
    public int GetHour()
    {
        UpdateTime();
        return startTime_.AddSeconds(simulatedSeconds_).Hour;
    }

    public int GetMinute()
    {
        UpdateTime();
        return startTime_.AddSeconds(simulatedSeconds_).Minute;
    }

    public int GetSecond()
    {
        UpdateTime();
        return startTime_.AddSeconds(simulatedSeconds_).Second;
    }

    private static DateTime startTime_ = DateTime.Now;
    private static float simulatedSeconds_ = 0f;
    private static int lastFrame_ = -1;

    private static void UpdateTime()
    {
        if (lastFrame_ == Time.frameCount)
        {
            return;
        }
        lastFrame_ = Time.frameCount;
        simulatedSeconds_ += Time.unscaledDeltaTime * PanelSave.TimeSpeed;
    }
}