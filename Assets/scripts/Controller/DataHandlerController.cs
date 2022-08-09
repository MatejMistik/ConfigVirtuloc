using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandlerController : Element
{
    

    public void SaveImageData()
    {
        App.imagesModel.tempPosition = App.imagesModel.canvasTransform.position;
        App.imagesModel.tempScale = App.imagesModel.canvasTransform.localScale;
        App.imagesModel.tempResX = App.imagesModel.rawImage.texture.width;
        App.imagesModel.tempResY = App.imagesModel.rawImage.texture.height;

    }


    public void SaveSlidersData()
    {
        App.imagesModel.slidersValuesList.Clear();
        foreach (var slider in App.imagesModel.sliders)
        {
            App.imagesModel.slidersValuesList.Add(slider.value);
        }

        App.imagesModel.sliderValuesArray = App.imagesModel.slidersValuesList.ToArray();
    }

    public void DeleteSliderData()
    {
        int i = 0;
        foreach (var slider in App.imagesModel.sliders)
        {
            slider.value = App.imagesModel.sliderValuesArray[i];
            i++;
        }

    }

    // Deletes temporarily data that was made during opened config window
    public void DeleteData()
    {
        App.imagesModel.canvasTransform.position = App.imagesModel.tempPosition;
        App.imagesModel.canvasTransform.localScale = App.imagesModel.tempScale;
        App.imagesModel.rawImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, App.imagesModel.tempResX);
        App.imagesModel.rawImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, App.imagesModel.tempResY);
    }
}
