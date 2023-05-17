using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = .1f;

    protected enum TurnSnapSelection 
    {
        _15 = 15,
        _30 = 30,
        _45 = 45
    }

    [SerializeField] protected TurnSnapSelection turnSnapAmount = TurnSnapSelection._15;

    Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ApplyPlayerMovement();
    }

    private void OnEnable()
    {
        InputManager.onTurnSnapPerformed += TurnSnapPerformedEvent;
    }

    void ApplyPlayerMovement()
    {
        //Vector3 cameraForwardVector = Camera.main.gameObject.transform.forward;
        //Vector3 cameraRightVector = Camera.main.gameObject.transform.right;
        Vector3 forwardVel = InputManager.moveForwardAxisValue * gameObject.transform.forward * Time.deltaTime * movementSpeed;
        Vector3 rightVel = InputManager.moveRightAxisValue * gameObject.transform.right * Time.deltaTime * movementSpeed;

        Vector3 movVelocity = forwardVel + rightVel;
        body.velocity = movVelocity;
    }

    void TurnSnapPerformedEvent(float value)
    {
        float v = Mathf.Sign(value);
        Vector3 targetRotation = (int)turnSnapAmount * Vector3.up * v;
        gameObject.transform.Rotate(targetRotation, Space.Self);
    }
}
