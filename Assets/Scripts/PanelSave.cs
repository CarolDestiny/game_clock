using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSave : MonoBehaviour
{
    public static float FocusMinutes
    {
        get { return PlayerPrefs.GetFloat("FocusMinutes", 25f); }
        set { PlayerPrefs.SetFloat("FocusMinutes", value); }
    }

    public static float BreakMinutes
    {
        get { return PlayerPrefs.GetFloat("BreakMinutes", 5f); }
        set { PlayerPrefs.SetFloat("BreakMinutes", value); }
    }

    public static float TimeSpeed
    {
        get { return PlayerPrefs.GetFloat("TimeSpeed", 1f); }
        set { PlayerPrefs.SetFloat("TimeSpeed", value); }
    }

    public static void Save()
    {
        PlayerPrefs.Save();
    }
}
