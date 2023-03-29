//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/TestBed/Inputs/VRTestBed.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace VRTestBed
{
    public partial class @StandardActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @StandardActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""VRTestBed"",
    ""maps"": [
        {
            ""name"": ""BasicMovement"",
            ""id"": ""66641d69-ecd4-42e4-9b6a-379008aa40f7"",
            ""actions"": [
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Value"",
                    ""id"": ""bd4b5936-ac2e-4524-bf5b-bd448bddfb7c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Value"",
                    ""id"": ""8598bddf-2b65-40be-9bc5-8bfc18d36857"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TurnSnap"",
                    ""type"": ""Value"",
                    ""id"": ""6d27da94-5188-4be4-a430-39be5c16f19c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""80bd94fa-81bb-4795-8bb3-0708036ba8a4"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83490fb7-6477-41d5-bc78-2284e0e6a47b"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32a24f2f-2bea-4e3e-80fa-c2aedf627c81"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TurnSnap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HandPoses"",
            ""id"": ""3bc5e29d-20fc-48ef-aa27-f834dc7aacd4"",
            ""actions"": [
                {
                    ""name"": ""GripLeft"",
                    ""type"": ""Button"",
                    ""id"": ""ef139089-9695-43ba-b36f-f52e6fb14259"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GripRight"",
                    ""type"": ""Button"",
                    ""id"": ""21f274ad-ec67-4b7d-b11d-b0ce77599ba5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TriggerLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4d4c284d-b4a2-4355-9a48-384aabb091fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TriggerRight"",
                    ""type"": ""Button"",
                    ""id"": ""beaa80f1-90b1-4f5d-ac0c-8a2c131bf4ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""935c36fa-8399-46d7-b6d6-d7afaf7d46a2"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""GripLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5b1a084-8a26-4217-b9ec-9dbd78fa44ee"",
                    ""path"": ""<OculusTouchController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""GripRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbe28ee6-4e0b-4388-8c2a-6d8f34657fb9"",
                    ""path"": ""<OculusTouchController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8d0362b-8ff9-4a0f-a8a8-ad0444c353e8"",
                    ""path"": ""<OculusTouchController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interactions"",
            ""id"": ""388c26c4-d697-4dc0-856d-35c7438fe4cf"",
            ""actions"": [
                {
                    ""name"": ""GrabLeft"",
                    ""type"": ""Button"",
                    ""id"": ""60b05edd-e62a-446c-b759-bc466cb85126"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GrabRight"",
                    ""type"": ""Button"",
                    ""id"": ""ce79fd9a-945c-4a1b-a08a-6dc843a4181a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b09584cc-7943-4dc8-9ed2-698be9ca05de"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cac99b3-4e9b-4cea-b13b-d9f117b705f8"",
                    ""path"": ""<OculusTouchController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // BasicMovement
            m_BasicMovement = asset.FindActionMap("BasicMovement", throwIfNotFound: true);
            m_BasicMovement_MoveForward = m_BasicMovement.FindAction("MoveForward", throwIfNotFound: true);
            m_BasicMovement_MoveRight = m_BasicMovement.FindAction("MoveRight", throwIfNotFound: true);
            m_BasicMovement_TurnSnap = m_BasicMovement.FindAction("TurnSnap", throwIfNotFound: true);
            // HandPoses
            m_HandPoses = asset.FindActionMap("HandPoses", throwIfNotFound: true);
            m_HandPoses_GripLeft = m_HandPoses.FindAction("GripLeft", throwIfNotFound: true);
            m_HandPoses_GripRight = m_HandPoses.FindAction("GripRight", throwIfNotFound: true);
            m_HandPoses_TriggerLeft = m_HandPoses.FindAction("TriggerLeft", throwIfNotFound: true);
            m_HandPoses_TriggerRight = m_HandPoses.FindAction("TriggerRight", throwIfNotFound: true);
            // Interactions
            m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
            m_Interactions_GrabLeft = m_Interactions.FindAction("GrabLeft", throwIfNotFound: true);
            m_Interactions_GrabRight = m_Interactions.FindAction("GrabRight", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // BasicMovement
        private readonly InputActionMap m_BasicMovement;
        private IBasicMovementActions m_BasicMovementActionsCallbackInterface;
        private readonly InputAction m_BasicMovement_MoveForward;
        private readonly InputAction m_BasicMovement_MoveRight;
        private readonly InputAction m_BasicMovement_TurnSnap;
        public struct BasicMovementActions
        {
            private @StandardActions m_Wrapper;
            public BasicMovementActions(@StandardActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveForward => m_Wrapper.m_BasicMovement_MoveForward;
            public InputAction @MoveRight => m_Wrapper.m_BasicMovement_MoveRight;
            public InputAction @TurnSnap => m_Wrapper.m_BasicMovement_TurnSnap;
            public InputActionMap Get() { return m_Wrapper.m_BasicMovement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BasicMovementActions set) { return set.Get(); }
            public void SetCallbacks(IBasicMovementActions instance)
            {
                if (m_Wrapper.m_BasicMovementActionsCallbackInterface != null)
                {
                    @MoveForward.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMoveForward;
                    @MoveForward.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMoveForward;
                    @MoveForward.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMoveForward;
                    @MoveRight.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMoveRight;
                    @MoveRight.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMoveRight;
                    @MoveRight.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMoveRight;
                    @TurnSnap.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnTurnSnap;
                    @TurnSnap.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnTurnSnap;
                    @TurnSnap.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnTurnSnap;
                }
                m_Wrapper.m_BasicMovementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveForward.started += instance.OnMoveForward;
                    @MoveForward.performed += instance.OnMoveForward;
                    @MoveForward.canceled += instance.OnMoveForward;
                    @MoveRight.started += instance.OnMoveRight;
                    @MoveRight.performed += instance.OnMoveRight;
                    @MoveRight.canceled += instance.OnMoveRight;
                    @TurnSnap.started += instance.OnTurnSnap;
                    @TurnSnap.performed += instance.OnTurnSnap;
                    @TurnSnap.canceled += instance.OnTurnSnap;
                }
            }
        }
        public BasicMovementActions @BasicMovement => new BasicMovementActions(this);

        // HandPoses
        private readonly InputActionMap m_HandPoses;
        private IHandPosesActions m_HandPosesActionsCallbackInterface;
        private readonly InputAction m_HandPoses_GripLeft;
        private readonly InputAction m_HandPoses_GripRight;
        private readonly InputAction m_HandPoses_TriggerLeft;
        private readonly InputAction m_HandPoses_TriggerRight;
        public struct HandPosesActions
        {
            private @StandardActions m_Wrapper;
            public HandPosesActions(@StandardActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @GripLeft => m_Wrapper.m_HandPoses_GripLeft;
            public InputAction @GripRight => m_Wrapper.m_HandPoses_GripRight;
            public InputAction @TriggerLeft => m_Wrapper.m_HandPoses_TriggerLeft;
            public InputAction @TriggerRight => m_Wrapper.m_HandPoses_TriggerRight;
            public InputActionMap Get() { return m_Wrapper.m_HandPoses; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(HandPosesActions set) { return set.Get(); }
            public void SetCallbacks(IHandPosesActions instance)
            {
                if (m_Wrapper.m_HandPosesActionsCallbackInterface != null)
                {
                    @GripLeft.started -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnGripLeft;
                    @GripLeft.performed -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnGripLeft;
                    @GripLeft.canceled -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnGripLeft;
                    @GripRight.started -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnGripRight;
                    @GripRight.performed -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnGripRight;
                    @GripRight.canceled -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnGripRight;
                    @TriggerLeft.started -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnTriggerLeft;
                    @TriggerLeft.performed -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnTriggerLeft;
                    @TriggerLeft.canceled -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnTriggerLeft;
                    @TriggerRight.started -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnTriggerRight;
                    @TriggerRight.performed -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnTriggerRight;
                    @TriggerRight.canceled -= m_Wrapper.m_HandPosesActionsCallbackInterface.OnTriggerRight;
                }
                m_Wrapper.m_HandPosesActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @GripLeft.started += instance.OnGripLeft;
                    @GripLeft.performed += instance.OnGripLeft;
                    @GripLeft.canceled += instance.OnGripLeft;
                    @GripRight.started += instance.OnGripRight;
                    @GripRight.performed += instance.OnGripRight;
                    @GripRight.canceled += instance.OnGripRight;
                    @TriggerLeft.started += instance.OnTriggerLeft;
                    @TriggerLeft.performed += instance.OnTriggerLeft;
                    @TriggerLeft.canceled += instance.OnTriggerLeft;
                    @TriggerRight.started += instance.OnTriggerRight;
                    @TriggerRight.performed += instance.OnTriggerRight;
                    @TriggerRight.canceled += instance.OnTriggerRight;
                }
            }
        }
        public HandPosesActions @HandPoses => new HandPosesActions(this);

        // Interactions
        private readonly InputActionMap m_Interactions;
        private IInteractionsActions m_InteractionsActionsCallbackInterface;
        private readonly InputAction m_Interactions_GrabLeft;
        private readonly InputAction m_Interactions_GrabRight;
        public struct InteractionsActions
        {
            private @StandardActions m_Wrapper;
            public InteractionsActions(@StandardActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @GrabLeft => m_Wrapper.m_Interactions_GrabLeft;
            public InputAction @GrabRight => m_Wrapper.m_Interactions_GrabRight;
            public InputActionMap Get() { return m_Wrapper.m_Interactions; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
            public void SetCallbacks(IInteractionsActions instance)
            {
                if (m_Wrapper.m_InteractionsActionsCallbackInterface != null)
                {
                    @GrabLeft.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrabLeft;
                    @GrabLeft.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrabLeft;
                    @GrabLeft.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrabLeft;
                    @GrabRight.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrabRight;
                    @GrabRight.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrabRight;
                    @GrabRight.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrabRight;
                }
                m_Wrapper.m_InteractionsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @GrabLeft.started += instance.OnGrabLeft;
                    @GrabLeft.performed += instance.OnGrabLeft;
                    @GrabLeft.canceled += instance.OnGrabLeft;
                    @GrabRight.started += instance.OnGrabRight;
                    @GrabRight.performed += instance.OnGrabRight;
                    @GrabRight.canceled += instance.OnGrabRight;
                }
            }
        }
        public InteractionsActions @Interactions => new InteractionsActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        private int m_JoystickSchemeIndex = -1;
        public InputControlScheme JoystickScheme
        {
            get
            {
                if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
                return asset.controlSchemes[m_JoystickSchemeIndex];
            }
        }
        private int m_XRSchemeIndex = -1;
        public InputControlScheme XRScheme
        {
            get
            {
                if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
                return asset.controlSchemes[m_XRSchemeIndex];
            }
        }
        public interface IBasicMovementActions
        {
            void OnMoveForward(InputAction.CallbackContext context);
            void OnMoveRight(InputAction.CallbackContext context);
            void OnTurnSnap(InputAction.CallbackContext context);
        }
        public interface IHandPosesActions
        {
            void OnGripLeft(InputAction.CallbackContext context);
            void OnGripRight(InputAction.CallbackContext context);
            void OnTriggerLeft(InputAction.CallbackContext context);
            void OnTriggerRight(InputAction.CallbackContext context);
        }
        public interface IInteractionsActions
        {
            void OnGrabLeft(InputAction.CallbackContext context);
            void OnGrabRight(InputAction.CallbackContext context);
        }
    }
}
