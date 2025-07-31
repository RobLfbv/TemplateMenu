using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

public enum MenuState
{
    MainMenu,
    Settings,
    Credits
}
public abstract class UIMenuBehaviour : MonoBehaviour
{
    //*****
    // Singleton pattern
    //*****
    private static UIMenuBehaviour _instance;
    public static UIMenuBehaviour Instance { get { return _instance; } }


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
    public AudioMixer audioMixer;

    [SerializeField]
    private List<Selectable> mainMenuSelectables;

    [SerializeField]
    private List<Selectable> settingsSelectables;

    [SerializeField]
    private List<Selectable> creditsSelectables;
    [SerializeField]
    private InputSystemUIInputModule inputSystemUIInputModule;
    private MenuState menuState;
    private void FixedUpdate()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            Vector2 vec = inputSystemUIInputModule.move.ToInputAction().ReadValue<Vector2>();
            if (vec != Vector2.zero)
            {
                switch (menuState)
                {
                    case MenuState.MainMenu:
                        mainMenuSelectables[0].Select();
                        break;
                    case MenuState.Settings:
                        settingsSelectables[0].Select();
                        break;
                    case MenuState.Credits:
                        creditsSelectables[0].Select();
                        break;
                }
            }
        }
    }

    public void ChangeMenuState(MenuState state)
    {
        menuState = state;
    }

    public void UnselectButton()
    {
        switch (menuState)
        {
            case MenuState.MainMenu:
                mainMenuSelectables[0].Select();
                break;
            case MenuState.Settings:
                settingsSelectables[0].Select();
                break;
            case MenuState.Credits:
                creditsSelectables[0].Select();
                break;
        }
    }
}
