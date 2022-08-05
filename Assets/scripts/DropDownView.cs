using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDownView : Element
{
    public TextMeshProUGUI output;
    public void HandleInputData(int val)
    {
        App.dropDownController.SetScreenToFit(val);
    }

}
