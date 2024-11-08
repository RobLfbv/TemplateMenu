using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanelButton : MonoBehaviour
{
    [SerializeField]
    private GameObject toDesactivatePanel;

    [SerializeField]
    private GameObject toActivatePanel;

    public void ChangePanel()
    {
        toDesactivatePanel.SetActive(false);
        toActivatePanel.SetActive(true);
    }

    public void Play()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
