using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitchController : Element
{
    public RawImage rawImage;
    public SpriteRenderer spriteRenderer;
    public Texture2D[] texture2DArray;
    private int i = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) MoveToImageOnRight();
        if (Input.GetKeyDown(KeyCode.LeftArrow)) MoveToImageOnLeft();
    }

    public void MoveToImageOnLeft()
    {
        if(i > 0)i--;
        rawImage.texture = texture2DArray[i];
    }

    public void MoveToImageOnRight()
    {
        if(i < texture2DArray.Length - 1 ) i++;
        rawImage.texture = texture2DArray[i];
    }

    public void GetImages(Texture2D[] texture2D)
    {
        texture2DArray = texture2D;
    }


}
