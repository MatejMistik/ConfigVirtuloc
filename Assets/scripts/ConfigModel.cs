using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigModel : Element
{
    // Start Data Save

    private float[] _values;
    public float[] Values
    {
        get { return _values; }
        set { _values = value; }
    }

    public void SaveData()
    {

    }
}
