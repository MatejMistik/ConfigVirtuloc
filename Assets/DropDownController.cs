using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownController : Element
{

    public RectTransform canvas;
    public void SetScreenToFit(int val)
    {
        switch (val)
        {
            case 0: RectTransformExtensions.SetAnchor(canvas, AnchorPresets.MiddleCenter); 
                break;
            case 1: RectTransformExtensions.SetAnchor(canvas, AnchorPresets.BottomRight);
                break;
            case 2: RectTransformExtensions.SetAnchor(canvas, AnchorPresets.HorStretchTop);
                break;
            default: RectTransformExtensions.SetAnchor(canvas, AnchorPresets.StretchAll);
                break;
        }
    }
}
