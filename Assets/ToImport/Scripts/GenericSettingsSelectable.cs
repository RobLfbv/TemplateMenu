using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class GenericSettingsSelectable<T> : MonoBehaviour
{
    [SerializeField] protected string playerPrefsItem;
    protected T UIItem;
    
    abstract public void OnValueChanged();
    protected void ToLaunchStart()
    {
        UIItem = GetComponent<T>();
    }
}
