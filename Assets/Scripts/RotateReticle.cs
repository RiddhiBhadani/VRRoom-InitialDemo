using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up, Time.deltaTime * Speed);
    }
}
