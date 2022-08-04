using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ConfigControllerButtons : Element
{

    //Pos
    public Button buttonIncX;
    public Button buttonDecX;
    public Slider sliderPosX;

    public Button buttonIncY;
    public Button buttonDecY;
    public Slider sliderPosY;

    public Button buttonIncZ;
    public Button buttonDecZ;
    public Slider sliderPosZ;

    //Scales
    public Button buttonScaleIncX;
    public Button buttonScaleDecX;
    public Slider sliderScaleX;

    public Button buttonScaleIncY;
    public Button buttonScaleDecY;
    public Slider sliderScaleY;

    //Res
    public Button buttonResIncX;
    public Button buttonResDecX;
    public Slider sliderResX;

    public Button buttonResIncY;
    public Button buttonResDecY;
    public Slider sliderResY;

    [SerializeField] float scaleAndPosValue = 0.01f;
    [SerializeField] float resValue = 1f;





    private void Awake()
    {



        // Position Buttons
        Button btnIncX = buttonIncX.GetComponent<Button>();
        btnIncX.onClick.AddListener(delegate { TaskOnClickInc(sliderPosX, scaleAndPosValue); });
        Button btnIncY = buttonIncY.GetComponent<Button>();
        btnIncY.onClick.AddListener(delegate { TaskOnClickInc(sliderPosY, scaleAndPosValue); });
        Button btnIncZ = buttonIncZ.GetComponent<Button>();
        btnIncZ.onClick.AddListener(delegate { TaskOnClickInc(sliderPosZ, scaleAndPosValue); });

        
        Button btnDecX = buttonDecX.GetComponent<Button>();
        btnDecX.onClick.AddListener(delegate { TaskOnClickDec(sliderPosX, scaleAndPosValue); });
        Button btnDecY = buttonDecY.GetComponent<Button>();
        btnDecY.onClick.AddListener(delegate { TaskOnClickDec(sliderPosY, scaleAndPosValue); });
        Button btnDecZ = buttonDecZ.GetComponent<Button>();
        btnDecZ.onClick.AddListener(delegate { TaskOnClickDec(sliderPosZ, scaleAndPosValue); });



        // Scale Buttons
        Button btnScaleIncX = buttonScaleIncX.GetComponent<Button>();
        btnScaleIncX.onClick.AddListener(delegate { TaskOnClickInc(sliderScaleX, scaleAndPosValue); });
        Button btnScaleIncY = buttonScaleIncY.GetComponent<Button>();
        btnScaleIncY.onClick.AddListener(delegate { TaskOnClickInc(sliderScaleY, scaleAndPosValue); });

        Button btnScaleDecX = buttonScaleDecX.GetComponent<Button>();
        btnScaleDecX.onClick.AddListener(delegate { TaskOnClickDec(sliderScaleX, scaleAndPosValue); });
        Button btnScaleDecY = buttonScaleDecY.GetComponent<Button>();
        btnScaleDecY.onClick.AddListener(delegate { TaskOnClickDec(sliderScaleY, scaleAndPosValue); });

        //Res Buttons
        Button btnResIncX = buttonResIncX.GetComponent<Button>();
        btnResIncX.onClick.AddListener(delegate { TaskOnClickInc(sliderResX, resValue); });
        Button btnResIncY = buttonResIncY.GetComponent<Button>();
        btnResIncY.onClick.AddListener(delegate { TaskOnClickInc(sliderResY, resValue); });

        Button btnResDecX = buttonResDecX.GetComponent<Button>();
        btnResDecX.onClick.AddListener(delegate { TaskOnClickDec(sliderResX, resValue); });
        Button btnResDecY = buttonResDecY.GetComponent<Button>();
        btnResDecY.onClick.AddListener(delegate { TaskOnClickDec(sliderResY, resValue); });




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
