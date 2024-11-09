using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSliderBrightness : SettingsSlider
{
    public override void OnValueChanged()
    {
        PlayerPrefs.SetFloat(playerPrefsItem, UIItem.value);
        Screen.brightness = PlayerPrefs.GetFloat(playerPrefsItem);
        textValue.text = "" + Mathf.RoundToInt(PlayerPrefs.GetFloat(playerPrefsItem) * 100);
    }
}
