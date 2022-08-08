using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigViewPosScale : Element
{
    

    public void Awake()
    {

        App.configModel.sliderPositionX.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.xCoordinate, App.configModel.sliderPositionX); App.imagesController.ChangePosition(App.configModel.sliderPositionX.value, 'x'); });
        App.configModel.sliderPositionY.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.yCoordinate, App.configModel.sliderPositionY); App.imagesController.ChangePosition(App.configModel.sliderPositionY.value, 'y'); });
        App.configModel.sliderPositionZ.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.zCoordinate, App.configModel.sliderPositionZ); App.imagesController.ChangePosition(App.configModel.sliderPositionZ.value, 'z'); });

        App.configModel.sliderScaleX.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.xScale, App.configModel.sliderScaleX); App.imagesController.ChangeScale(App.configModel.sliderScaleX.value, 'x'); });
        App.configModel.sliderScaleY.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.yScale, App.configModel.sliderScaleY); App.imagesController.ChangeScale(App.configModel.sliderScaleY.value, 'y'); });

        App.configModel.sliderResX.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.xRes, App.configModel.sliderResX); App.imagesController.ChangeRes(App.configModel.sliderResX.value, 'x', App.configModel.toggleOneByOne.isOn); });
        App.configModel.sliderResY.onValueChanged.AddListener(delegate { ValueChangeCheck(App.configModel.yRes, App.configModel.sliderResY); App.imagesController.ChangeRes(App.configModel.sliderResY.value, 'y', App.configModel.toggleOneByOne.isOn); });
    }

    public void ValueChangeCheck(TextMeshProUGUI text, Slider slider)
    {

        text.SetText(slider.value.ToString("0.00"));
    }


}

