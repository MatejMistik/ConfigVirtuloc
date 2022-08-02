using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;

public class Controller : Element
{

    public Transform transformOfSprite;

    public void ChangePosition(float sliderValue, char token)
    {

        switch (token)
        {
            case 'x': transformOfSprite.position = new Vector3(sliderValue, 0f, 0f);
                break;
            case 'y': transformOfSprite.position = new Vector3(0f, sliderValue, 0f);
                break;
            default: transformOfSprite.position = new Vector3(0f, 0f, sliderValue);
                break;
        }

        

    }

    public void ChangeScale(float sliderValue, char token)
    {
        switch (token)
        {
            case 'x':
                transformOfSprite.localScale = new Vector3(sliderValue, 1f, 1f);
                break;
            default:
                transformOfSprite.localScale = new Vector3(1f, sliderValue, 1f);
                break;
        }

    }

    


    /*
    private void FixedUpdate()
    {
        application.configModel.xCoordinate.SetText(application.configModel.sliderPositionX.value.ToString("0.00"));
    }


    
     public void ValueChangeCheck(float value, string coordinate)
     {
         Debug.Log(coordinate +"" +  value);
         coordinate = (value.ToString("0.00"));
         application.configModel.xCoordinate.SetText(coordinate);
     }
    
    */
}
