using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownController : Element
{
  
    public void SetScreenToFit(int val)
    {
        switch (val)
        {
            case 0: RectTransformExtensions.SetAnchor(App.imagesModel.canvasRectTransform, AnchorPresets.MiddleCenter); 
                break;
            case 1: RectTransformExtensions.SetAnchor(App.imagesModel.canvasRectTransform, AnchorPresets.BottomRight);
                break;
            case 2: RectTransformExtensions.SetAnchor(App.imagesModel.canvasRectTransform, AnchorPresets.HorStretchTop);
                break;
            default: RectTransformExtensions.SetAnchor(App.imagesModel.canvasRectTransform, AnchorPresets.StretchAll);
                break;
        }
    }
}
