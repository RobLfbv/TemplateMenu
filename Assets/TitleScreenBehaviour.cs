using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum OpenPanel
{
    MainMenu, Settings, Credits
}

public class TiltleScreenBehaviour : MonoBehaviour
{
    [SerializeField]
    private List<Button> mainMenuButtons;

    [SerializeField]
    private List<Button> settingsButtons;

    [SerializeField]
    private List<Button> creditsButtons;
}
