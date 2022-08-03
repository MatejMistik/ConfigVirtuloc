using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigView : Element
{
    public TextMeshProUGUI xCoordinate;
    public Slider sliderPositionX;

    public TextMeshProUGUI yCoordinate;
    public Slider sliderPositionY;

    public TextMeshProUGUI zCoordinate;
    public Slider sliderPositionZ;

    public TextMeshProUGUI xScale;
    public Slider sliderScaleX;

    public TextMeshProUGUI yScale;
    public Slider sliderScaleY;

    


    public void Awake()
    {
        sliderPositionX.onValueChanged.AddListener(delegate { ValueChangeCheck(xCoordinate, sliderPositionX); App.imagesController.ChangePosition(sliderPositionX.value, 'x'); });
        sliderPositionY.onValueChanged.AddListener(delegate { ValueChangeCheck(yCoordinate, sliderPositionY); App.imagesController.ChangePosition(sliderPositionY.value, 'y'); });
        sliderPositionZ.onValueChanged.AddListener(delegate { ValueChangeCheck(zCoordinate, sliderPositionZ); App.imagesController.ChangePosition(sliderPositionZ.value, 'z'); });
        sliderScaleX.onValueChanged.AddListener(delegate { ValueChangeCheck(xScale, sliderScaleX); App.imagesController.ChangeScale(sliderScaleX.value, 'x'); });
        sliderScaleY.onValueChanged.AddListener(delegate { ValueChangeCheck(yScale, sliderScaleY); App.imagesController.ChangeScale(sliderScaleY.value, 'y'); });
    }

    public void ValueChangeCheck(TextMeshProUGUI text, Slider slider)
    {

        text.SetText(slider.value.ToString("0.00"));
    }


}

