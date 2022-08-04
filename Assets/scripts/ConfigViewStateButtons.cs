using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ConfigViewStateButtons : Element
{

    public Button saveButton;
    public Button deleteButton;
    public Button closeButton;

    private void Awake()
    {
        saveButton.onClick.AddListener(delegate { App.configStateButtonController.OnClickSaveButton(); });
        deleteButton.onClick.AddListener(delegate { App.configStateButtonController.OnClickDeleteButton(); });
        closeButton.onClick.AddListener(delegate { App.configStateButtonController.CloseConfig(); }); // can add delete data or save data on close..

    }

   
}
