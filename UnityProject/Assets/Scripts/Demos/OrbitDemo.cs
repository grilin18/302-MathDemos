using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitDemo : MonoBehaviour
{
    public Transform orbitCenter;
    public float radius = 10;
    public int pathResolution = 32;

    private LineRenderer path;

    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<LineRenderer>();
        UpdateOrbitPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (orbitCenter == null) return;

        float x = radius * Mathf.Cos(Time.time);
        float z = radius * Mathf.Sin(Time.time);

        transform.position = new Vector3(x, 0, z) + orbitCenter.position;

        if (orbitCenter.hasChanged) UpdateOrbitPath();
    }

    void UpdateOrbitPath()
    {
        if (orbitCenter == null) return;

        

        Vector3[] pts = new Vector3[pathResolution];

        for (int i = 0; i < pts.Length; i++)
        {

            float x = radius * Mathf.Cos(i * 2 * Mathf.PI / pathResolution);
            float z = radius * Mathf.Sin(i * 2 * Mathf.PI / pathResolution);

            Vector3 pt = new Vector3(x, 0, z) + orbitCenter.position;
            pts[i] = pt;
        }
        path.positionCount = pathResolution;
        path.SetPositions(pts);
    }

}
