using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigModel : Element
{
    // Start Data Save
    // could be done with single GameObject reference
    public Transform imagesCanvasTransform;
    public SpriteRenderer spriteRenderer;
    private Vector3 tempPosition;
    private Vector3 tempScale;
    private Vector2 tempRes;

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
        tempRes = spriteRenderer.size;

    }

    public void DeleteData()
    {
        imagesCanvasTransform.position = tempPosition;
        imagesCanvasTransform.localScale = tempScale;
        spriteRenderer.size = tempRes;
    }
}
