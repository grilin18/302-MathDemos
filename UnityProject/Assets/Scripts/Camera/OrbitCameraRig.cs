using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCameraRig : MonoBehaviour
{

    private float pitch = 0;
    private float yaw = 0;
    private float disToTarget = 10;

    public float mouseSensitivityX = 1;
    public float mouseSensitivityY = -1;
    public float scrollSensitivity = 5;

    private Camera cam;

    public Transform thingToLookAt;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //postition
        if (thingToLookAt == null) return;
        //transform.position = thingToLookAt.position;

        transform.position = AnimMath.Ease(transform.position, thingToLookAt.position, .001f, Time.deltaTime);

        //rotation
        float mx = Input.GetAxis("Mouse X"); //yaw (Y axis)
        float my = Input.GetAxis("Mouse Y"); //pitch (X axis)

        yaw += mx * mouseSensitivityX;
        pitch += my * mouseSensitivityY;

        pitch = Mathf.Clamp(pitch, -89, 89);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);

        //dolly
        Vector2 scrollAmt = Input.mouseScrollDelta;
        disToTarget += scrollAmt.y * scrollSensitivity;

        disToTarget = Mathf.Clamp(disToTarget, 5, 50);

        float z = AnimMath.Ease(cam.transform.localPosition.z, -disToTarget, 0.1f, Time.deltaTime);

        cam.transform.localPosition = new Vector3(0, 0, -disToTarget);

    }
}
