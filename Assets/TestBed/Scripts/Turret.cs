using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform turretBase;

    [Header("Rotation Settings")]
    [Range(0, 180)]
    public float rightRotationLimit;
    [Range(0, 180)]
    public float leftRotationLimit;
    [Range(0, 180)]
    public float elevationRotationLimit;
    [Range(0, 180)]
    public float depressionRotationLimit;
    [Range(0, 180)]
    public float turnSpeed;

    bool _isGrabbed;

    private void Update()
    {
        
    }

    void GrabCheck()
    {

    }
}
