using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigStateButtonController : Element
{


    public void OnClickSaveButton()
    {
        App.configModel.SaveImageData();
        App.configModel.SaveSlidersData();
        CloseConfig();


    }

    public void OnClickDeleteButton()
    {
        App.configModel.DeleteData();
        App.configModel.DeleteSliderData();
    }

    public void CloseConfig()
    {
        App.configOpener.configuratorViewGameObject.SetActive(false);
    }

}
