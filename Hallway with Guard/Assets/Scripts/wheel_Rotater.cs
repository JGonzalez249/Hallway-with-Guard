using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_Rotater : MonoBehaviour
{

    public Transform WheelLtransform;
    public Transform WheelRtransform;



    void Update()
    {
        WheelLtransform.Rotate(3, 0, 0);
        WheelRtransform.Rotate(-3, 0, 0);
    }
}
