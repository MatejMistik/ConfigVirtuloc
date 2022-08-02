using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigModel : Element
{
    public TextMeshProUGUI xCoordinate;
    [SerializeField] TextMeshProUGUI yCoordinate;
    [SerializeField] TextMeshProUGUI zCoordinate;

    [SerializeField] TextMeshProUGUI scaleX;
    [SerializeField] TextMeshProUGUI scaleY;

    public Slider sliderPositionX;
    [SerializeField] Slider sliderScale;

    public void Awake()
    {
        sliderPositionX.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {

        xCoordinate.SetText(sliderPositionX.value.ToString("0.00"));
    }

}

