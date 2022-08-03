using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigModel : Element
{
    // Start Data Save

    public Transform imagesCanvasTransform;
    private Vector3 tempPosition;
    private Vector3 tempScale;

    private float[] _values;
    public float[] Values
    {
        get { return _values; }
        set { _values = value; }
    }

    public void SaveData()
    {
        tempPosition = imagesCanvasTransform.position;
        tempScale = imagesCanvasTransform.localScale;
    }

    public void DeleteData()
    {
        imagesCanvasTransform.position = tempPosition;
        imagesCanvasTransform.localScale = tempScale;
    }
}
