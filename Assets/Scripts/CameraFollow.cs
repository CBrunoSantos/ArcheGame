using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{

    private Func<Vector3> GetCameraFollowPositionFunc;
    public void Setup(Func<Vector3> GetCameraFollowPositionFunc){
        this.GetCameraFollowPositionFunc = GetCameraFollowPositionFunc;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 cameraFollowPosition = GetCameraFollowPositionFunc();

        Vector3 cameraMoveDir = (cameraFollowPosition - transform.position).normalized;
        float distance = Vector3.Distance(cameraFollowPosition,  transform.position);
        float cameraMoveSpeed = 1f;

        cameraFollowPosition.z = transform.position.z;


        // transform.position = transform.position + cameraMoveDir * distance * cameraMoveSpeed * Time.deltaTime;
        transform.position = cameraFollowPosition;
    }
}
