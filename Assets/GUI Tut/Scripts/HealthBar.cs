using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Color fullColor = Color.green;
    [SerializeField]
    private Color emptyColor = Color.red;
    [SerializeField]
    private Slider healthSlider;
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private Image healthDisplay;
       

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.value = healthSlider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.color = Color.Lerp(emptyColor, fullColor, Mathf.Clamp01(healthSlider.value / healthSlider.maxValue));
        healthText.text = healthSlider.value.ToString("0.0");
    }
}
