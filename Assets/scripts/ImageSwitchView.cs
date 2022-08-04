using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitchView : Element
{
    public Button buttonLeft;
    public Button buttonRight;


    private void Awake()
    {
        buttonLeft.onClick.AddListener(delegate { TaskOnClickLeft(); });
        buttonRight.onClick.AddListener(delegate { TaskOnClickRight(); });
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
