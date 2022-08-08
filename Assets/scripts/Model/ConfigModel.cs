using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigModel : Element
{
    // Start Data Save
    // could be done with single GameObject reference
    private Vector3 tempPosition;
    private Vector3 tempScale;
    private int tempResX;
    private int tempResY;

    [SerializeField] Slider[] sliders;


    private readonly List<float> slidersValuesList = new();
    private float[] sliderValuesArray;

    // Sliders 


    //Pos
    public TextMeshProUGUI xCoordinate;
    public Slider sliderPositionX;

    public TextMeshProUGUI yCoordinate;
    public Slider sliderPositionY;

    public TextMeshProUGUI zCoordinate;
    public Slider sliderPositionZ;

    //Scale
    public TextMeshProUGUI xScale;
    public Slider sliderScaleX;

    public TextMeshProUGUI yScale;
    public Slider sliderScaleY;


    //Res
    public TextMeshProUGUI xRes;
    public Slider sliderResX;

    public TextMeshProUGUI yRes;
    public Slider sliderResY;

    //Buttons

    //Pos
    public Button buttonIncX;
    public Button buttonDecX;

    public Button buttonIncY;
    public Button buttonDecY;

    public Button buttonIncZ;
    public Button buttonDecZ;

    //Scale
    public Button buttonScaleIncX;
    public Button buttonScaleDecX;

    public Button buttonScaleIncY;
    public Button buttonScaleDecY;

    //Res
    public Button buttonResIncX;
    public Button buttonResDecX;

    public Button buttonResIncY;
    public Button buttonResDecY;

    //StateButtons
    public Button saveButton;
    public Button deleteButton;
    public Button closeButton;


    public Toggle toggleOneByOne;

    public TMP_Dropdown dropdown;

    public void SaveImageData()
    {
        tempPosition = App.imagesModel.canvasTransform.position;
        tempScale = App.imagesModel.canvasTransform.localScale;
        tempResX = App.imagesModel.rawImage.texture.width;
        tempResY = App.imagesModel.rawImage.texture.height;


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

    // Deletes temporarily data that was made during opened config window
    public void DeleteData()
    {
        App.imagesModel.canvasTransform.position = tempPosition;
        App.imagesModel.canvasTransform.localScale = tempScale;
        App.imagesModel.rawImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,tempResX);
        App.imagesModel.rawImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, tempResY);
    }
}
