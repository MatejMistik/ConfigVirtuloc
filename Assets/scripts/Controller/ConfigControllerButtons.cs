using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigControllerButtons : Element
{

   
    [SerializeField] float scaleAndPosValue = 0.01f;
    [SerializeField] float resValue = 1f;


    private void Awake()
    {

        // Position Buttons
        Button btnIncX = App.configModel.buttonIncX.GetComponent<Button>();
        btnIncX.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderPositionX, scaleAndPosValue); });
        Button btnIncY = App.configModel.buttonIncY.GetComponent<Button>();
        btnIncY.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderPositionY, scaleAndPosValue); });
        Button btnIncZ = App.configModel.buttonIncZ.GetComponent<Button>();
        btnIncZ.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderPositionZ, scaleAndPosValue); });

        
        Button btnDecX = App.configModel.buttonDecX.GetComponent<Button>();
        btnDecX.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderPositionX, scaleAndPosValue); });
        Button btnDecY = App.configModel.buttonDecY.GetComponent<Button>();
        btnDecY.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderPositionY, scaleAndPosValue); });
        Button btnDecZ = App.configModel.buttonDecZ.GetComponent<Button>();
        btnDecZ.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderPositionZ, scaleAndPosValue); });



        // Scale Buttons
        Button btnScaleIncX = App.configModel.buttonScaleIncX.GetComponent<Button>();
        btnScaleIncX.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderScaleX, scaleAndPosValue); });
        Button btnScaleIncY = App.configModel.buttonScaleIncY.GetComponent<Button>();
        btnScaleIncY.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderScaleY, scaleAndPosValue); });

        Button btnScaleDecX = App.configModel.buttonScaleDecX.GetComponent<Button>();
        btnScaleDecX.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderScaleX, scaleAndPosValue); });
        Button btnScaleDecY = App.configModel.buttonScaleDecY.GetComponent<Button>();
        btnScaleDecY.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderScaleY, scaleAndPosValue); });

        //Res Buttons
        Button btnResIncX = App.configModel.buttonResIncX.GetComponent<Button>();
        btnResIncX.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderResX, resValue); });
        Button btnResIncY = App.configModel.buttonResIncY.GetComponent<Button>();
        btnResIncY.onClick.AddListener(delegate { TaskOnClickInc(App.configModel.sliderResY, resValue); });

        Button btnResDecX = App.configModel.buttonResDecX.GetComponent<Button>();
        btnResDecX.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderResX, resValue); });
        Button btnResDecY = App.configModel.buttonResDecY.GetComponent<Button>();
        btnResDecY.onClick.AddListener(delegate { TaskOnClickDec(App.configModel.sliderResY, resValue); });


    }

    private void TaskOnClickInc(Slider slider, float value)
    {
        slider.value += value;
    }

    private void TaskOnClickDec(Slider slider, float value)
    {
        slider.value -= value;
    }

}
