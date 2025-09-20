using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderInput : MonoBehaviour
{
    public Slider slider;
    public TMP_Text text_value;

    public void HandleSliderValueChanged(float value)
    {
        text_value.SetText(value.ToString("F2"));
    }

}
