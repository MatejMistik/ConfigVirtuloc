using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigOpener : Element
{
    
    public GameObject configuratorViewGameObject;
    // Start is called before the first frame update
    void Awake()
    { 
        configuratorViewGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            configuratorViewGameObject.SetActive(true);
            App.configModel.SaveData();
            App.imagesController.LoadTransformOfImage();
            
        }
    }

    public void CloseConfig()
    {
        configuratorViewGameObject.SetActive(false);
    }
    
}
