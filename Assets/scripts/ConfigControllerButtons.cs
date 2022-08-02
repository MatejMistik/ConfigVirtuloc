using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ConfigControllerButtons : Element
{
    public Button buttonIncX;
    public Button buttonDecX;
    public Slider sliderPosX;

    public Button buttonIncY;
    public Button buttonDecY;
    public Slider sliderPosY;

    public Button buttonIncZ;
    public Button buttonDecZ;
    public Slider sliderPosZ;

    public Button buttonScaleIncX;
    public Button buttonScaleDecX;
    public Slider sliderScaleX;

    public Button buttonScaleIncY;
    public Button buttonScaleDecY;
    public Slider sliderScaleY;



    private void Awake()
    {



        // Position Buttons
        Button btnIncX = buttonIncX.GetComponent<Button>();
        btnIncX.onClick.AddListener(delegate { TaskOnClickInc(sliderPosX); });
        Button btnIncY = buttonIncY.GetComponent<Button>();
        btnIncY.onClick.AddListener(delegate { TaskOnClickInc(sliderPosY); });
        Button btnIncZ = buttonIncZ.GetComponent<Button>();
        btnIncZ.onClick.AddListener(delegate { TaskOnClickInc(sliderPosZ); });

        
        Button btnDecX = buttonDecX.GetComponent<Button>();
        btnDecX.onClick.AddListener(delegate { TaskOnClickDec(sliderPosX); });
        Button btnDecY = buttonDecY.GetComponent<Button>();
        btnDecY.onClick.AddListener(delegate { TaskOnClickDec(sliderPosY); });
        Button btnDecZ = buttonDecZ.GetComponent<Button>();
        btnDecZ.onClick.AddListener(delegate { TaskOnClickDec(sliderPosZ); });



        // Scale Buttons
        Button btnScaleIncX = buttonScaleIncX.GetComponent<Button>();
        btnScaleIncX.onClick.AddListener(delegate { TaskOnClickInc(sliderScaleX); });
        Button btnScaleIncY = buttonScaleIncY.GetComponent<Button>();
        btnScaleIncY.onClick.AddListener(delegate { TaskOnClickInc(sliderScaleY); });

        Button btnScaleDecX = buttonScaleDecX.GetComponent<Button>();
        btnScaleDecX.onClick.AddListener(delegate { TaskOnClickDec(sliderScaleX); });
        Button btnScaleDecY = buttonScaleDecY.GetComponent<Button>();
        btnScaleDecY.onClick.AddListener(delegate { TaskOnClickInc(sliderScaleY); });




    }

    private void TaskOnClickInc(Slider slider)
    {
        slider.value += 0.01f;
    }

    private void TaskOnClickDec(Slider slider)
    {
        slider.value-= 0.01f;
    }

}
