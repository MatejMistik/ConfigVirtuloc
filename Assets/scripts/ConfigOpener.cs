using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigOpener : Element
{
    
    public GameObject configuratorGameObject;
    // Start is called before the first frame update
    void Awake()
    {
        configuratorGameObject = GameObject.Find("view/ConfigView");
        configuratorGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            configuratorGameObject.SetActive(true);
        }
    }

    public void CloseConfig()
    {
        configuratorGameObject.SetActive(false);
    }
    
}
