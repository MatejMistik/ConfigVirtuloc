using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;

public class Controller : Element
{

    public Transform transformOfSprite;
    public Transform canvasTrasnform;
    public Vector3 beforeSavePos;
    

    public void SaveTransformPos()
    {
         Vector3 BeforeSavePositon = canvasTrasnform.position;
    }

    public void ChangePosition(float sliderValue, char token)
    {

        transformOfSprite.position = token switch
        {
            'x' => new Vector3(sliderValue, canvasTrasnform.position.y, canvasTrasnform.position.z),
            'y' => new Vector3(canvasTrasnform.position.x, sliderValue, canvasTrasnform.position.z),
            _ => new Vector3(canvasTrasnform.position.x, canvasTrasnform.position.y, sliderValue),
        };
    }

    public void ChangeScale(float sliderValue, char token)
    {
        transformOfSprite.localScale = token switch
        {
            'x' => new Vector3(sliderValue, canvasTrasnform.localScale.y, canvasTrasnform.localScale.z),
            _ => new Vector3(canvasTrasnform.localScale.x, sliderValue, canvasTrasnform.localScale.z),
        };
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
