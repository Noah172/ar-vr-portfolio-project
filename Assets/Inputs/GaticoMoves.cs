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
                    ""path"": ""<Keyboard>/a"",
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
                    ""path"": ""<Keyboard>/d"",
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
                    ""path"": ""<Gamepad>/leftStick"",
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
    public struct MawwActions
    {
        private @GaticoMoves m_Wrapper;
        public MawwActions(@GaticoMoves wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Maww_Jump;
        public InputAction @Movement => m_Wrapper.m_Maww_Movement;
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
            }
        }
    }
    public MawwActions @Maww => new MawwActions(this);
    public interface IMawwActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
