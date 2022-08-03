using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigStateButtonController : Element
{


    public void OnClickSaveButton()
    {
        App.configModel.SaveData();
   
    }

    public void OnClickDeleteButton()
    {
        App.configModel.DeleteData();
    }

}
