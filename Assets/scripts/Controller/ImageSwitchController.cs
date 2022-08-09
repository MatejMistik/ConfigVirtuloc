using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitchController : Element
{
    // only SerialezeField to check in Editor
    public Texture2D[] texture2DArray;
    public int i = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) MoveToImageOnRight();
        if (Input.GetKeyDown(KeyCode.LeftArrow)) MoveToImageOnLeft();
    }

    public void MoveToImageOnLeft()
    {
        if (i == 0) { App.imagesModel.buttonRight.enabled = false; }
        else
        {
            App.imagesModel.buttonRight.enabled = true;
        }
        if (i > 0)i--;
        App.imagesModel.rawImage.texture = texture2DArray[i];
    }

    public void MoveToImageOnRight()
    {
        if (i == texture2DArray.Length) { App.imagesModel.buttonLeft.enabled = false; }
        else
        {
            App.imagesModel.buttonLeft.enabled = true;
        }
        
        if (i < texture2DArray.Length - 1)
        {
            i++;
        }
        App.imagesModel.rawImage.texture = texture2DArray[i];
    }

    public void FillClickBaits()
    {
        int i = 0;
        foreach (var clickBait in App.imagesModel.clickBaits)
        {
            Debug.Log(texture2DArray.Length);
            clickBait.texture = texture2DArray[i];
            if(texture2DArray.Length - 1>= i)i++;
        }
    }

    public void DipslayChosenClickBaitAsImage(int value)
    {
        App.imagesModel.rawImage.texture = texture2DArray[value];
    }


    public void GetImages(Texture2D[] texture2D)
    {
        texture2DArray = texture2D;
    }


}
