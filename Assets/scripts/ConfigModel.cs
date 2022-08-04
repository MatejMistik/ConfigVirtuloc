using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigModel : Element
{
    // Start Data Save
    // could be done with single GameObject reference
    public Transform imagesCanvasTransform;
    public SpriteRenderer spriteRenderer;
    private Vector3 tempPosition;
    private Vector3 tempScale;
    private Vector2 tempRes;
    [SerializeField] Slider[] sliders;


    private List<float> slidersValues = new();
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
        tempRes = spriteRenderer.size;

    }

    public void SaveSlidersData()
    {
        foreach (var slider in sliders)
        {
            slidersValues.Add(slider.value);
        }

        sliderValuesArray = slidersValues.ToArray();
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
        spriteRenderer.size = tempRes;
    }
}
