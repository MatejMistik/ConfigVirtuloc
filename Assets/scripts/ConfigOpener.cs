using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigOpener : Element
{
    
    public GameObject configuratorViewGameObject;
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
            App.imagesController.LoadTransformOfImage();
            App.configModel.SaveImageData();
            App.configModel.SaveSlidersData();
            App.imagesModel.imageCanvas.renderMode = RenderMode.WorldSpace;

        }
    }
  
    
}
