using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    private GameObject ball;
    Vector3 distance;



    void Start()
    {
        ball = GameObject.Find("Sphere").gameObject;
        distance = transform.position = ball.transform.position;
    }

    void LateUpdate()
    {
        transform.position = ball.transform.position + distance;
    }
}
