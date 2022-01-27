using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TweenDemo : MonoBehaviour
{
    public AnimationCurve curve;

    public Transform pointA;
    public Transform pointB;

    private bool isPlaying = false;

    private float currTime = 0;

    [Range(.25f, 5)]
    public float timeTotal = 2;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            currTime += Time.deltaTime;
            doInterp();
        }
    }

    void doInterp(){

        if (pointA == null) return;
        if (pointB == null) return;

        float p = currTime / timeTotal;

        p = curve.Evaluate(p);

        Vector3 pos = AnimMath.Lerp(pointA.position, pointB.position, p, false);

        transform.position = pos;

        if (p > 1) isPlaying = false;
    }

    public void StartTween()
    {
        isPlaying = true;
        currTime = 0;
    }


}

[CustomEditor(typeof(TweenDemo))]
public class EditorTweenDemo : Editor {
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Start Tween"))
        {
            (target as TweenDemo).StartTween();
        }

    }
}
