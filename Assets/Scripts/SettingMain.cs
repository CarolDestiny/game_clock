using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMain : MonoBehaviour
{
    [Header("Panel")]
    [SerializeField] private GameObject panel_;

    [Header("focus")]
    [SerializeField] private Slider focusSlider_;

    [Header("break")]
    [SerializeField] private Slider breakSlider_;

    [Header("speed")]
    [SerializeField] private Slider speedSlider_;

    [Header("Save Button")]
    [SerializeField] private Button saveButton_;

    private bool is_open_;

    // save data
    private void SaveData()
    {
        PanelSave.FocusMinutes = focusSlider_.value;
        PanelSave.BreakMinutes = breakSlider_.value;
        PanelSave.TimeSpeed = speedSlider_.value;
        PanelSave.Save();
    }

    void Start()
    {
        /* load data */
        focusSlider_.value = PanelSave.FocusMinutes;
        breakSlider_.value = PanelSave.BreakMinutes;
        speedSlider_.value = PanelSave.TimeSpeed;
        /* end load data */

        saveButton_.onClick.AddListener(this.SaveData);

        panel_.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            is_open_ = !is_open_;
            panel_.SetActive(is_open_);
        }
    }
}
