using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    private Vector3 initPosition;
    private void Start() {
        initPosition= transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(initPosition, Vector3.back, Time.deltaTime*50);
    }
}
