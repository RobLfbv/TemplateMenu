using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSliderAudio : SettingsSlider
{
    [SerializeField]
    private string audioMixerItem;

    public override void OnValueChanged()
    {
        PlayerPrefs.SetFloat(playerPrefsItem, UIItem.value);
        TiltleScreenBehaviour.Instance.audioMixer.SetFloat(audioMixerItem, Mathf.Log10(PlayerPrefs.GetFloat(playerPrefsItem)) * 20);
        textValue.text = "" + Mathf.RoundToInt(PlayerPrefs.GetFloat(playerPrefsItem) * 100);
    }
}
