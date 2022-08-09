using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigModel : Element
{
    // Start Data Save
   

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

    
}
