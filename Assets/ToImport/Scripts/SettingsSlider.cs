using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
abstract public class SettingsSlider : GenericSettingsSelectable<Slider>
{
    [SerializeField]
    protected TMP_Text textValue;
    protected void OnEnable()
    {
        ToLaunchStart();
        UIItem.value = PlayerPrefs.GetFloat(playerPrefsItem);
        textValue.text = "" + Mathf.RoundToInt(PlayerPrefs.GetFloat(playerPrefsItem) * 100);
    }
}
