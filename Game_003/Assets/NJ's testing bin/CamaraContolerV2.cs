using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraContolerV2 : MonoBehaviour {

    public Transform Traget;

    public Vector3 offset;
    private float CurrentZoom = 10f;
    private float currentYaw = 0f;

    public float pitch = 2f;
    public float ZoomSpeed = 4f;
    public float MinZoom = 5f;
    public float MaxZoom = 15f;
    public float yawSpeed = 100f;

    private void LateUpdate()
    {
        transform.position = Traget.position - offset * CurrentZoom;
        transform.LookAt(Traget.position + Vector3.up * pitch);

        transform.RotateAround(Traget.position, Vector3.up, currentYaw);
    }
	
	void Update () {
        CurrentZoom -= Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
        CurrentZoom = Mathf.Clamp(CurrentZoom, MinZoom, MaxZoom);

        currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
	}
}
