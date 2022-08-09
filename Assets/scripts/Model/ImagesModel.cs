using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagesModel : Element
{
    public Button buttonLeft;
    public Button buttonRight;
    public Button[] imagesButtons;
    public RawImage rawImage;
    public Canvas imageCanvas;
    public RectTransform rawImageRectTransform;
    public Transform canvasTransform;
    public RectTransform canvasRectTransform;
    public RawImage[] clickBaits;

    // could be done with single GameObject reference
    public Vector3 tempPosition;
    public Vector3 tempScale;
    public int tempResX;
    public int tempResY;

    public Slider[] sliders;


    public List<float> slidersValuesList = new();
    public float[] sliderValuesArray;
}
