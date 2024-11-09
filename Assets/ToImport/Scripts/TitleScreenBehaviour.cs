using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public enum OpenPanel
{
    MainMenu, Settings, Credits
}

public class TiltleScreenBehaviour : MonoBehaviour
{
    //*****
    // Singleton pattern
    //*****
    private static TiltleScreenBehaviour _instance;
    public static TiltleScreenBehaviour Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    //*****
    // Singleton pattern
    //*****

    [SerializeField]
    private List<Button> mainMenuButtons;

    [SerializeField]
    private List<Button> settingsButtons;

    [SerializeField]
    private List<Button> creditsButtons;

    [SerializeField]
    public AudioMixer audioMixer;

    [SerializeField]
    private List<string> mixerItem;

    private IEnumerator Start()
    {
        //Lang selection
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[PlayerPrefs.GetInt("ChoosedLang")];

        //Audio settings handler
        foreach (string item in mixerItem)
        {
            if (!PlayerPrefs.HasKey(item))
            {
                PlayerPrefs.SetFloat(item, 1);
            }
        }

        audioMixer.SetFloat("Master", Mathf.Log10(PlayerPrefs.GetFloat("MasterVolume")) * 20);
        audioMixer.SetFloat("Music", Mathf.Log10(PlayerPrefs.GetFloat("MusicVolume")) * 20);
        audioMixer.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("SFXVolume")) * 20);
        audioMixer.SetFloat("Voice", Mathf.Log10(PlayerPrefs.GetFloat("VoiceVolume")) * 20);

        // Brightness
        if (!PlayerPrefs.HasKey("Brightness"))
        {
            PlayerPrefs.SetFloat("Brightness", 1);
        }
        Screen.brightness = PlayerPrefs.GetFloat("Brightness");

        // Vibrations
        if (!PlayerPrefs.HasKey("Vibrations"))
        {
            PlayerPrefs.SetInt("Vibrations", 1);
        }

        // InvertX
        if (!PlayerPrefs.HasKey("InvertX"))
        {
            PlayerPrefs.SetInt("InvertX", 0);
        }

        // InvertY
        if (!PlayerPrefs.HasKey("InvertY"))
        {
            PlayerPrefs.SetInt("InvertY", 0);
        }

        // Subtitles
        if (!PlayerPrefs.HasKey("Subtitles"))
        {
            PlayerPrefs.SetInt("Subtitles", 1);
        }


    }
}
