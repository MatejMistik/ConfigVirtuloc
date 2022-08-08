using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitchView : Element
{
    
    private void Awake()
    {
        App.imagesModel.buttonLeft.onClick.AddListener(delegate { TaskOnClickLeft(); });
        App.imagesModel.buttonRight.onClick.AddListener(delegate { TaskOnClickRight(); });
    }

    public void TaskOnClickLeft()
    {
        App.imageSwitchController.MoveToImageOnLeft();

    }

    public void TaskOnClickRight()
    {
        App.imageSwitchController.MoveToImageOnRight();

    }

}
