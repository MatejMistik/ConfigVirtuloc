using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigModel : Element
{
    // Start Data Save
    // could be done with single GameObject reference
    public Transform imagesCanvasTransform;
    public RawImage rawImage;
    private Vector3 tempPosition;
    private Vector3 tempScale;
    private int tempResX;
    private int tempResY;

    [SerializeField] Slider[] sliders;


    private readonly List<float> slidersValuesList = new();
    private float[] sliderValuesArray;
    private float[] _values;
    
    public float[] Values
    {
        get { return _values; }
        set { _values = value; }
    }

    public void SaveImageData()
    {
        tempPosition = imagesCanvasTransform.position;
        tempScale = imagesCanvasTransform.localScale;
        tempResX = rawImage.texture.width;
        tempResY = rawImage.texture.height;


    }

    public void SaveSlidersData()
    {
        slidersValuesList.Clear();
        foreach (var slider in sliders)
        {
            slidersValuesList.Add(slider.value);
        }

        sliderValuesArray = slidersValuesList.ToArray();
    }

    public void DeleteSliderData()
    {
        int i = 0;
        foreach (var slider in sliders)
        {
            slider.value = sliderValuesArray[i];
            i++;
        }
        

        
    }

    public void DeleteData()
    {
        imagesCanvasTransform.position = tempPosition;
        imagesCanvasTransform.localScale = tempScale;
        rawImage.texture.width = tempResX ;
        rawImage.texture.height = tempResY;
    }
}
