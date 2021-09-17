// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/GaticoMoves.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GaticoMoves : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GaticoMoves()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GaticoMoves"",
    ""maps"": [
        {
            ""name"": ""Maww"",
            ""id"": ""f4281fbb-68f2-4e85-b741-135f17a8f893"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""790632dd-e28c-4372-b800-bebe7a9e42a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""06ac1275-9279-4ef6-8f6e-049c58cd855b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MainShoot"",
                    ""type"": ""Button"",
                    ""id"": ""9d659781-6e00-4488-9f43-c6ad5c5681c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryShoot"",
                    ""type"": ""Button"",
                    ""id"": ""a0d42885-a820-47a2-a4f9-6ea4c06be42a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""moves"",
                    ""id"": ""1db9d46a-0bab-467b-ae41-47d41682d0d0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""95e62236-be62-4151-848b-26dda2769455"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed41f28f-c3a3-43e7-8b5d-2bb9f7ed88a7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""866fa4e5-2e2f-4c06-8550-51239ea88e25"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16744e62-4756-4180-ac0a-5e2064438c43"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""jumper"",
                    ""id"": ""f883ee8b-e848-4f00-9de3-eaefcd7d3b45"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""72a95895-15ab-4765-92f2-bb0ef92c59b2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""52f483a8-34d3-4365-b94a-0bc453eff045"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf191e0e-ace6-4fe2-9e4d-312fb53ebaf4"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2f2fd2a-e991-4444-8968-76f44bb14388"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be1a4be-c3a8-4f2b-a9b8-6ce75fc48114"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bbf5f39-ea15-42ba-b81b-27e95207c1df"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Maww
        m_Maww = asset.FindActionMap("Maww", throwIfNotFound: true);
        m_Maww_Jump = m_Maww.FindAction("Jump", throwIfNotFound: true);
        m_Maww_Movement = m_Maww.FindAction("Movement", throwIfNotFound: true);
        m_Maww_MainShoot = m_Maww.FindAction("MainShoot", throwIfNotFound: true);
        m_Maww_SecondaryShoot = m_Maww.FindAction("SecondaryShoot", throwIfNotFound: true);
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

    // Maww
    private readonly InputActionMap m_Maww;
    private IMawwActions m_MawwActionsCallbackInterface;
    private readonly InputAction m_Maww_Jump;
    private readonly InputAction m_Maww_Movement;
    private readonly InputAction m_Maww_MainShoot;
    private readonly InputAction m_Maww_SecondaryShoot;
    public struct MawwActions
    {
        private @GaticoMoves m_Wrapper;
        public MawwActions(@GaticoMoves wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Maww_Jump;
        public InputAction @Movement => m_Wrapper.m_Maww_Movement;
        public InputAction @MainShoot => m_Wrapper.m_Maww_MainShoot;
        public InputAction @SecondaryShoot => m_Wrapper.m_Maww_SecondaryShoot;
        public InputActionMap Get() { return m_Wrapper.m_Maww; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MawwActions set) { return set.Get(); }
        public void SetCallbacks(IMawwActions instance)
        {
            if (m_Wrapper.m_MawwActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_MawwActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MawwActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MawwActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_MawwActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MawwActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MawwActionsCallbackInterface.OnMovement;
                @MainShoot.started -= m_Wrapper.m_MawwActionsCallbackInterface.OnMainShoot;
                @MainShoot.performed -= m_Wrapper.m_MawwActionsCallbackInterface.OnMainShoot;
                @MainShoot.canceled -= m_Wrapper.m_MawwActionsCallbackInterface.OnMainShoot;
                @SecondaryShoot.started -= m_Wrapper.m_MawwActionsCallbackInterface.OnSecondaryShoot;
                @SecondaryShoot.performed -= m_Wrapper.m_MawwActionsCallbackInterface.OnSecondaryShoot;
                @SecondaryShoot.canceled -= m_Wrapper.m_MawwActionsCallbackInterface.OnSecondaryShoot;
            }
            m_Wrapper.m_MawwActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MainShoot.started += instance.OnMainShoot;
                @MainShoot.performed += instance.OnMainShoot;
                @MainShoot.canceled += instance.OnMainShoot;
                @SecondaryShoot.started += instance.OnSecondaryShoot;
                @SecondaryShoot.performed += instance.OnSecondaryShoot;
                @SecondaryShoot.canceled += instance.OnSecondaryShoot;
            }
        }
    }
    public MawwActions @Maww => new MawwActions(this);
    public interface IMawwActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnMainShoot(InputAction.CallbackContext context);
        void OnSecondaryShoot(InputAction.CallbackContext context);
    }
}
