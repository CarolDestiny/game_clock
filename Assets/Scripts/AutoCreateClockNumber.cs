using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoCreateClockNumber : MonoBehaviour
{
    public GameObject numberPrefab;
    public float radius = 4f;
    void Start()
    {
        for (int n = 1; n <= 12; n++)
        {
            float angle = -n * 30 * MathF.PI / 180;

            Vector3 pos = new Vector3(
                0.3f,                         // 圆盘偏移
                Mathf.Cos(angle) * radius,    // 高度
                -Mathf.Sin(angle) * radius    // 左右
            );

            GameObject go = Instantiate(numberPrefab, pos, Quaternion.Euler(0, -90, 0));
            go.name = "Clock_number" + n;
            go.GetComponentInChildren<TMP_Text>().text = n.ToString();
        }
    }
    void Update()
    {
        
    }
}
