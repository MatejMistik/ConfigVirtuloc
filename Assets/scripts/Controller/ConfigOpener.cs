using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigOpener : Element
{
    
    public GameObject configuratorViewGameObject;
    public GameObject imagesPanel;
    // Start is called before the first frame update
    void Start()
    { 
        configuratorViewGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            configuratorViewGameObject.SetActive(true);
            imagesPanel.SetActive(false);
            App.imagesController.LoadTransformOfImage();
            App.dataHandlerController.SaveImageData();
            App.dataHandlerController.SaveSlidersData();
            App.imagesModel.imageCanvas.renderMode = RenderMode.WorldSpace;

        }
    }
  
    
}
