using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimMath 
{
    public static float Lerp(float a, float b, float p, bool allowExtrapolation = true)
    {
        if (!allowExtrapolation)
        {
            if (p > 1) p = 1;
            if (p < 0) p = 0;
        }

        return (b - a) * p + a;
    }

    public static Vector3 Lerp(Vector3 a, Vector3 b, float p, bool allowExtrapolation = true)
    {
        if (!allowExtrapolation)
        {
            if (p > 1) p = 1;
            if (p < 0) p = 0;
        }

        return (b - a) * p + a;
    }

    public static float Map(float v, float mina, float maxa, float minb, float maxb)
    {
        float p = (v - mina) / (maxa - mina);
        return Lerp(minb, maxb, p);
    }

    public static Quaternion Lerp(Quaternion a, Quaternion b, float p, bool allowExtrapolation = false)
    {
        if (!allowExtrapolation)
        {
            if (p > 1) p = 1;
            if (p < 0) p = 0;
        }

        Quaternion rot = Quaternion.identity;

        rot.x = Lerp(a.x, b.x, p);
        rot.y = Lerp(a.y, b.y, p);
        rot.z = Lerp(a.z, b.z, p);
        rot.w = Lerp(a.w, b.w, p);

        return rot;
    }

    public static float Ease(float current, float target, float percentLeftAfter1Second, float dt)
    {
        float p = 1 - Mathf.Pow(percentLeftAfter1Second, dt);

        return Lerp(current, target, p);
    }

    public static Vector3 Ease(Vector3 current, Vector3 target, float percentLeftAfter1Second, float dt)
    {
        float p = 1 - Mathf.Pow(percentLeftAfter1Second, dt);

        return Lerp(current, target, p);
    }

}
