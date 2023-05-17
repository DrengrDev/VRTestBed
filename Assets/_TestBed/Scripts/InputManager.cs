using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static VRTestBed.StandardActions;

public class InputManager : MonoBehaviour , IBasicMovementActions , IInteractionsActions , IHandPosesActions
{
    public VRTestBed.StandardActions standardActions;
    private static InputManager _instance;

    public static float moveForwardAxisValue = 0.0f;
    public static float moveRightAxisValue = 0.0f;

    public delegate void Movement_OnTurnSnapPerformedDelegate(float value);
    public static event Movement_OnTurnSnapPerformedDelegate onTurnSnapPerformed;

    #region Interaction Actions

    public delegate void Interaction_OnGrabLeftStartDelegate();
    public delegate void Interaction_OnGrabLeftCanceledDelegate();
    public static event Interaction_OnGrabLeftStartDelegate interactionOnGrabLeftStartEvent;
    public static event Interaction_OnGrabLeftStartDelegate interactionOnGrabLeftCanceledEvent;

    public delegate void Interaction_OnGrabRightStartDelegate();
    public delegate void Interaction_OnGrabRightCanceledDelegate();
    public static event Interaction_OnGrabLeftStartDelegate interactionOnGrabRightStartEvent;
    public static event Interaction_OnGrabLeftStartDelegate interactionOnGrabRightCanceledEvent;

    #endregion

    #region Hand Poses Action Map Interface Implementation

    public delegate void HandPoses_OnGripLeftStartedDelegate();
    public delegate void HandPoses_OnGripLeftCanceledDelegate();
    public delegate void HandPoses_OnGripRightStartedDelegate();
    public delegate void HandPoses_OnGripRightPerformedDelegate();
    public delegate void HandPoses_OnGripRightCanceledDelegate();
    public delegate void HandPoses_OnTriggerLeftStartedDelegate();
    public delegate void HandPoses_OnTriggerLeftCanceledDelegate();
    public delegate void HandPoses_OnTriggerRightStartedDelegate();
    public delegate void HandPoses_OnTriggerRightCanceledDelegate();

    public static event HandPoses_OnGripLeftStartedDelegate handPosesOnGripLeftStartedEvent;
    public static event HandPoses_OnGripLeftCanceledDelegate handPosesOnGripLeftCanceledEvent;
    public static event HandPoses_OnGripRightStartedDelegate handPosesOnGripRightStartedEvent;
    public static event HandPoses_OnGripRightCanceledDelegate handPosesOnGripRightCanceledEvent;
    public static event HandPoses_OnTriggerLeftStartedDelegate handPosesOnTriggerLeftStartedEvent;
    public static event HandPoses_OnTriggerLeftCanceledDelegate handPosesOnTriggerLeftCanceledEvent;
    public static event HandPoses_OnTriggerRightStartedDelegate handPosesOnTriggerRightStartedEvent;
    public static event HandPoses_OnTriggerRightCanceledDelegate handPosesOnTriggerRightCanceledEvent;


    #endregion


    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(_instance);
            return;
        }
        else
        {
            _instance = this;
        }

        DontDestroyOnLoad(this);

        standardActions = new VRTestBed.StandardActions();

        standardActions.BasicMovement.SetCallbacks(this);
        standardActions.HandPoses.SetCallbacks(this);
        standardActions.Interactions.SetCallbacks(this);
    }

    private void OnEnable()
    {
        standardActions.BasicMovement.Enable();
        standardActions.HandPoses.Enable();
        standardActions.Interactions.Enable();
    }

    private void OnDisable()
    {
        standardActions.BasicMovement.Disable();
        standardActions.HandPoses.Disable();
        standardActions.Interactions.Disable();
    }

    #region Basic Movement Interface

    public void OnMoveForward(InputAction.CallbackContext context)
    {
        moveForwardAxisValue = context.ReadValue<float>();
    }

    public void OnMoveRight(InputAction.CallbackContext context)
    {
        moveRightAxisValue = context.ReadValue<float>();
    }

    public void OnTurnSnap(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            onTurnSnapPerformed.Invoke(context.ReadValue<float>());
        }
    }

    #endregion

    #region Hand Poses Action Map

    public void OnGripLeft(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            handPosesOnGripLeftStartedEvent.Invoke();
        }
        else if (context.canceled)
        {
            handPosesOnGripLeftCanceledEvent.Invoke();
        }
    }

    public void OnGripRight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            handPosesOnGripRightStartedEvent.Invoke();
        }
        else if (context.canceled)
        {
            handPosesOnGripRightCanceledEvent.Invoke();
        }
    }
    public void OnTriggerLeft(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            handPosesOnTriggerLeftStartedEvent.Invoke();
        }
        else if (context.canceled)
        {
            handPosesOnTriggerLeftCanceledEvent.Invoke();
        }
    }

    public void OnTriggerRight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            handPosesOnTriggerRightStartedEvent.Invoke();
        }
        else if (context.canceled)
        {
            handPosesOnTriggerRightCanceledEvent.Invoke();
        }
    }

    #endregion

    #region Interaction Action Map Interface

    public void OnGrabLeft(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            interactionOnGrabLeftStartEvent.Invoke();
        }
        else if (context.canceled)
        {
            interactionOnGrabLeftCanceledEvent.Invoke();
        }
    }

    public void OnGrabRight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            interactionOnGrabRightStartEvent.Invoke();
        }
        else if (context.canceled)
        {
            interactionOnGrabRightCanceledEvent.Invoke();
        }
    }

    #endregion
}
