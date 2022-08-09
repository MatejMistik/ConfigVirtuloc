using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesController : Element
{

    //public Vector3 beforeSavePos;

    public float distanceFromImage;
    private readonly float worldSpaceAdditionNeeded = 960f;


    public void ChangePosition(float sliderValue, char token)
    {

        App.imagesModel.canvasTransform.position = token switch
        {
            'x' => new Vector3(sliderValue, App.imagesModel.canvasTransform.position.y, App.imagesModel.canvasTransform.position.z),
            'y' => new Vector3(App.imagesModel.canvasTransform.position.x, sliderValue, App.imagesModel.canvasTransform.position.z),
            _ => new Vector3(App.imagesModel.canvasTransform.position.x, App.imagesModel.canvasTransform.position.y, sliderValue),
        };
    }

    public void ChangeScale(float sliderValue, char token)
    {
        App.imagesModel.canvasTransform.localScale = token switch
        {
            'x' => new Vector3(sliderValue, App.imagesModel.canvasTransform.localScale.y, App.imagesModel.canvasTransform.localScale.z),
            _ => new Vector3(App.imagesModel.canvasTransform.localScale.x, sliderValue, App.imagesModel.canvasTransform.localScale.z),
        };
    }

    public void ChangeRes(float sliderValue, char token, bool toggle)
    {

        // toggle is for OneByOne Ration of image
        if (toggle) {
            App.imagesModel.rawImageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sliderValue);
            App.imagesModel.rawImageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, sliderValue);
            // Buttons position depends on resolution of image
            App.imagesModel.buttonLeft.transform.position = new Vector3((-sliderValue / 2f ) - distanceFromImage + worldSpaceAdditionNeeded, App.imagesModel.buttonLeft.transform.position.y, App.imagesModel.buttonLeft.transform.position.z);
            App.imagesModel.buttonRight.transform.position = new Vector3((sliderValue / 2f) + distanceFromImage + worldSpaceAdditionNeeded, App.imagesModel.buttonRight.transform.position.y, App.imagesModel.buttonRight.transform.position.z);

            // To show value changed on both of the axis simultanoesly
            App.configModel.sliderResX.value = sliderValue;
            App.configModel.sliderResY.value = sliderValue;
        } 
        else {
            switch (token)
            {
                case 'x':
                    // Setting size for X axis
                    App.imagesModel.rawImageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sliderValue);
                    // Buttons position depends on resolution of image
                    App.imagesModel.buttonLeft.transform.position = new Vector3((-sliderValue / 2f) - distanceFromImage + worldSpaceAdditionNeeded, App.imagesModel.buttonLeft.transform.position.y, App.imagesModel.buttonLeft.transform.position.z);
                    App.imagesModel.buttonRight.transform.position = new Vector3((sliderValue / 2f) + distanceFromImage + worldSpaceAdditionNeeded, App.imagesModel.buttonRight.transform.position.y, App.imagesModel.buttonRight.transform.position.z);
                    break;
                default:
                    App.imagesModel.rawImageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, sliderValue);
                    break;
            }
        }
        
        
    }


    public void LoadTransformOfImage()
    {
        App.configModel.sliderPositionX.value = App.imagesModel.canvasTransform.position.x;
        App.configModel.sliderPositionY.value = App.imagesModel.canvasTransform.position.y;
        App.configModel.sliderPositionZ.value = App.imagesModel.canvasTransform.position.z;

        App.configModel.sliderScaleX.value = App.imagesModel.canvasTransform.localScale.x;
        App.configModel.sliderScaleY.value = App.imagesModel.canvasTransform.localScale.y;

        App.configModel.sliderResX.value = App.imagesModel.rawImage.texture.width;
        App.configModel.sliderResY.value = App.imagesModel.rawImage.texture.height;
    }




}
