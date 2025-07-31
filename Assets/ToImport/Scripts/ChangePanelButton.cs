using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangePanelButton : MonoBehaviour
{
    [SerializeField]
    private GameObject toDesactivatePanel;

    [SerializeField]
    private GameObject toActivatePanel;
    [SerializeField]
    private MenuState stateToChange;
    [SerializeField]
    private Selectable toSelectOnChangePanel;

    public void ChangePanel()
    {
        toDesactivatePanel.SetActive(false);
        toActivatePanel.SetActive(true);
        UIMenuBehaviour.Instance.ChangeMenuState(stateToChange);
        toSelectOnChangePanel.Select();
    }

    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
