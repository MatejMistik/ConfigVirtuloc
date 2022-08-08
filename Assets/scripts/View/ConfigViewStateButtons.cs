using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ConfigViewStateButtons : Element
{

    

    private void Awake()
    {
        App.configModel.saveButton.onClick.AddListener(delegate { App.configStateButtonController.OnClickSaveButton(); });
        App.configModel.deleteButton.onClick.AddListener(delegate { App.configStateButtonController.OnClickDeleteButton(); });
        App.configModel.closeButton.onClick.AddListener(delegate { App.configStateButtonController.CloseConfig(); }); // can add delete data or save data on close..

    }

   
}
