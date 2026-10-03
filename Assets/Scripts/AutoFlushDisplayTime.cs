using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AutoFlushDisplayTime : MonoBehaviour
{

    [SerializeField] private TMP_Text text_;

    [Header("beep")]
    [SerializeField] private AudioClip beepClip_;
    private float remain_;
    private bool is_focus_ = true;

    void Start()
    {
        StartFocus();
    }

    void Update()
    {
        remain_ -= Time.deltaTime * PanelSave.TimeSpeed;
        if (remain_ <= 0f)
        {
            if (is_focus_) StartBreak();
            else StartFocus();
        }

        int m = Mathf.FloorToInt(remain_ / 60f);
        int s = Mathf.FloorToInt(remain_ % 60f);

        text_.text = m.ToString("00") + ":" + s.ToString("00");

        text_.color = is_focus_ ? Color.red : Color.blue;
    }

    void StartFocus()
    {
        is_focus_ = true;
        remain_ = PanelSave.FocusMinutes * 60f;
        PlayBeep();
    }

    void StartBreak()
    {
        is_focus_ = false;
        remain_ = PanelSave.BreakMinutes * 60f;
        PlayBeep();
    }

    void PlayBeep()
    {
        if (beepClip_ == null) return;
        AudioSource.PlayClipAtPoint(
            beepClip_,
            Camera.main.transform.position
        );
    }
}
