using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject popupPanel;

    private void Start()
    {
        popupPanel.SetActive(false);  // Initially hide the Popup
    }

    public void ShowPopup()
    {
        popupPanel.SetActive(true);  // Show the Popup
    }

    public void HidePopup()
    {
        popupPanel.SetActive(false);  // Hide the Popup
    }
}
