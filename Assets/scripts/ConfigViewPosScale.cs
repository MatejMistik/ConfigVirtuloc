using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigViewPosScale : Element
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

    public TextMeshProUGUI xRes;
    public Slider sliderResX;

    public TextMeshProUGUI yRes;
    public Slider sliderResY;

    public Toggle toggle;






    public void Awake()
    {
        toggle.isOn = false;

        sliderPositionX.onValueChanged.AddListener(delegate { ValueChangeCheck(xCoordinate, sliderPositionX); App.imagesController.ChangePosition(sliderPositionX.value, 'x'); });
        sliderPositionY.onValueChanged.AddListener(delegate { ValueChangeCheck(yCoordinate, sliderPositionY); App.imagesController.ChangePosition(sliderPositionY.value, 'y'); });
        sliderPositionZ.onValueChanged.AddListener(delegate { ValueChangeCheck(zCoordinate, sliderPositionZ); App.imagesController.ChangePosition(sliderPositionZ.value, 'z'); });

        sliderScaleX.onValueChanged.AddListener(delegate { ValueChangeCheck(xScale, sliderScaleX); App.imagesController.ChangeScale(sliderScaleX.value, 'x'); });
        sliderScaleY.onValueChanged.AddListener(delegate { ValueChangeCheck(yScale, sliderScaleY); App.imagesController.ChangeScale(sliderScaleY.value, 'y'); });

        sliderResX.onValueChanged.AddListener(delegate { ValueChangeCheck(xRes, sliderResX); App.imagesController.ChangeRes(sliderResX.value, 'x', toggle.isOn); });
        sliderResY.onValueChanged.AddListener(delegate { ValueChangeCheck(yRes, sliderResY); App.imagesController.ChangeRes(sliderResY.value, 'y', toggle.isOn); });
    }

    public void ValueChangeCheck(TextMeshProUGUI text, Slider slider)
    {

        text.SetText(slider.value.ToString("0.00"));
    }


}

