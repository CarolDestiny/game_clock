using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueText : MonoBehaviour
{
    [Header("Slider")]
    [SerializeField] private Slider slider_;

    [Header("Text")]
    [SerializeField] private TMP_Text text_;

    [Header("prefix")]
    [SerializeField] private string prefix_;

    [Header("suffix")]
    [SerializeField] private string suffix_;

    void Start()
    {
        slider_.onValueChanged.AddListener(UpdateText);
        UpdateText(slider_.value);
    }

    void UpdateText(float value)
    {
        text_.text = prefix_ + value.ToString() + suffix_;
    }
}
