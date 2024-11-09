using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSettings : GenericSettingsSelectable<Toggle>
{
    private void OnEnable()
    {
        ToLaunchStart();
        UIItem.isOn = PlayerPrefs.GetInt(playerPrefsItem) == 1 ? true : false;
    }

    override public void OnValueChanged()
    {
        PlayerPrefs.SetInt(playerPrefsItem, UIItem.isOn ? 1 : 0);
    }
}
