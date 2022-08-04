using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitchController : Element
{
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
        Sprite sprite = Sprite.Create(texture2DArray[i], new Rect(-10, -10, texture2DArray[i].width, texture2DArray[i].height), Vector2.zero, 256);
        spriteRenderer.sprite = sprite;
    }

    public void MoveToImageOnRight()
    {
        if(i < texture2DArray.Length - 1 ) i++;
        Sprite sprite = Sprite.Create(texture2DArray[i], new Rect(-10, -10, texture2DArray[i].width, texture2DArray[i].height), Vector2.zero, 256);
        spriteRenderer.sprite = sprite;
    }

    public void GetImages(Texture2D[] texture2D)
    {
        texture2DArray = texture2D;
    }


}
