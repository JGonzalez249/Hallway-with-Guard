using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBlade : MonoBehaviour
{

    public Transform Blade;

    void Update()
    {
        Blade.Rotate(10, 0, 0);
    }
}
