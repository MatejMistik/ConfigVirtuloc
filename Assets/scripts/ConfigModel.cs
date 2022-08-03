using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigModel : Element
{
    // Start Data Save

    public Transform imagesCanvasTransform;
    private Vector3 tempPosition;

    private float[] _values;
    public float[] Values
    {
        get { return _values; }
        set { _values = value; }
    }

    public void SaveData()
    {
        tempPosition = imagesCanvasTransform.position;
    }

    public void DeleteData()
    {
        imagesCanvasTransform.position = tempPosition;
    }
}
