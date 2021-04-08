using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public float speedH = 2f;
    public float speedV = 2f;

    public float yaw = 0f;
    public float pitch = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxisRaw("Mouse X") * Time.deltaTime;
        pitch -= speedV * Input.GetAxisRaw("Mouse Y") * Time.deltaTime;

        transform.eulerAngles = new Vector3(pitch, yaw);
    }
}
