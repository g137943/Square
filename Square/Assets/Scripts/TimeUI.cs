using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    public float remainingTime;
    TextMeshPro textMeshPro;
    TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        if (textMeshPro == null)
            textMeshProUGUI = GetComponent<TextMeshProUGUI>();

        if (textMeshPro == null && textMeshProUGUI == null)
            Debug.LogWarning("TimeUI: 未找到 TextMeshPro 或 TextMeshProUGUI 组件，请把脚本挂到包含文本组件的对象上。");
    }

    private void Update()
    {
        if (TimeManager.instance == null) return;

        remainingTime = TimeManager.instance.remainingTime;

        // 取整秒数（向下取整）。如需向上取整请改为 Mathf.CeilToInt，四舍五入请用 Mathf.RoundToInt。
        int seconds = Mathf.FloorToInt(Mathf.Max(0f, remainingTime));

        string text = $"剩余时间：{seconds}秒";

        if (textMeshPro != null)
            textMeshPro.text = text;
        else if (textMeshProUGUI != null)
            textMeshProUGUI.text = text;
    }
}
