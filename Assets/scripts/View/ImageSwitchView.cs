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
        int i = 0;
        foreach (var item in App.imagesModel.imagesButtons)
        {
            int j = i;
            item.onClick.AddListener(delegate { App.imageSwitchController.DipslayChosenClickBaitAsImage(j); });
            i++;
        }
        
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
