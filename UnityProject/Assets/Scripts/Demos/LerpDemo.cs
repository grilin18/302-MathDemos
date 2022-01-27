using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{

    public Transform point1;
    public Transform point2;

    [Range(0, 1)]
    public float percent = 0;

    void doInterpolation()
    {
        if (point1 == null) return;
        if (point2 == null) return;
        Vector3 pos = AnimMath.Lerp(point1.position, point2.position, percent, false);

        Quaternion rot = AnimMath.Lerp(point1.rotation, point2.rotation, percent);

        transform.position = pos;
        transform.rotation = rot;
    }

    private void OnValidate()
    {
        doInterpolation();
    }
}
