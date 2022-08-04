using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigViewToggle : Element
{

    public Toggle toggle;
    private void Awake()
    {
        
        toggle.isOn = false;
        Debug.Log(toggle);
    }
}
