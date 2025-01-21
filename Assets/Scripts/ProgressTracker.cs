using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : Singleton<ProgressTracker>
{
    public static ProgressTracker Instance;
    bool isGlassesOn=false;

    public void SetIsGlassesOn(bool _value)
    {
        isGlassesOn = _value;
    }

    public bool GetIsGlassesOn() { return isGlassesOn; }
}
