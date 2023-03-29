using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsAnimtor : MonoBehaviour
{
    public Animator rightHand;
    public Animator leftHand;

    bool gripRight;
    bool triggerRight;
    bool gripLeft;
    bool triggerLeft;

    private void OnEnable()
    {
        InputManager.handPosesOnGripRightStartedEvent += InputManager_GripRightStartEvent;
        InputManager.handPosesOnGripRightCanceledEvent += InputManager_GripRightCanceledEvent;
        InputManager.handPosesOnTriggerRightStartedEvent += InputManager_TriggerRightStartEvent;
        InputManager.handPosesOnTriggerRightCanceledEvent += InputManager_TriggerRightCanceledEvent;

        InputManager.handPosesOnGripLeftStartedEvent += InputManager_GripLeftStartEvent;
        InputManager.handPosesOnGripLeftCanceledEvent += InputManager_GripLeftCanceledEvent;
        InputManager.handPosesOnTriggerLeftStartedEvent += InputManager_TriggerLeftStartEvent;
        InputManager.handPosesOnTriggerLeftCanceledEvent += InputManager_TriggerLeftCanceledEvent;
    }

    private void OnDisable()
    {
        InputManager.handPosesOnGripRightStartedEvent -= InputManager_GripRightStartEvent;
        InputManager.handPosesOnGripRightCanceledEvent -= InputManager_GripRightCanceledEvent;
        InputManager.handPosesOnTriggerRightStartedEvent -= InputManager_TriggerRightStartEvent;
        InputManager.handPosesOnTriggerRightCanceledEvent -= InputManager_TriggerRightCanceledEvent;

        InputManager.handPosesOnGripLeftStartedEvent -= InputManager_GripLeftStartEvent;
        InputManager.handPosesOnGripLeftCanceledEvent -= InputManager_GripLeftCanceledEvent;
        InputManager.handPosesOnTriggerLeftStartedEvent -= InputManager_TriggerLeftStartEvent;
        InputManager.handPosesOnTriggerLeftCanceledEvent -= InputManager_TriggerLeftCanceledEvent;
    }

    private void Update()
    {
        if (!gripRight && !triggerRight) rightHand.SetTrigger("Idle");
        else if (gripRight && !triggerRight) rightHand.SetTrigger("Grip");
        else if (!gripRight && triggerRight) rightHand.SetTrigger("Trigger");
        else if (gripRight && triggerRight) rightHand.SetTrigger("Both");

        if (!gripLeft && !triggerLeft) leftHand.SetTrigger("Idle");
        else if (gripLeft && !triggerLeft) leftHand.SetTrigger("Grip");
        else if (!gripLeft && triggerLeft) leftHand.SetTrigger("Trigger");
        else if (gripLeft && triggerLeft) leftHand.SetTrigger("Both");
    }

    #region Right Hand Events

    private void InputManager_GripRightStartEvent()
    {
        gripRight = true;
    }

    private void InputManager_GripRightCanceledEvent()
    {
        gripRight = false;
    }
    private void InputManager_TriggerRightStartEvent()
    {
        triggerRight = true;
    }
    private void InputManager_TriggerRightCanceledEvent()
    {
        triggerRight = false;
    }

    #endregion

    #region Left Hand Events

    private void InputManager_GripLeftStartEvent()
    {
        gripLeft = true;
    }

    private void InputManager_GripLeftCanceledEvent()
    {
        gripLeft = false;
    }
    private void InputManager_TriggerLeftStartEvent()
    {
        triggerLeft = true;
    }
    private void InputManager_TriggerLeftCanceledEvent()
    {
        triggerLeft = false;
    }

    #endregion
}
