// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/MouseControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MouseControl"",
    ""maps"": [
        {
            ""name"": ""MouseActions"",
            ""id"": ""856f97c5-292c-4442-9c73-373e31420087"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Button"",
                    ""id"": ""cbe881ec-8919-4cf3-a87d-204815fb7cdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d17f1a0f-52ac-459e-95b4-e1245d4bda31"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9276eb96-9e80-439e-a0f2-92bf0c428cd8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseActions
        m_MouseActions = asset.FindActionMap("MouseActions", throwIfNotFound: true);
        m_MouseActions_Mouse = m_MouseActions.FindAction("Mouse", throwIfNotFound: true);
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

    // MouseActions
    private readonly InputActionMap m_MouseActions;
    private IMouseActionsActions m_MouseActionsActionsCallbackInterface;
    private readonly InputAction m_MouseActions_Mouse;
    public struct MouseActionsActions
    {
        private @MouseControl m_Wrapper;
        public MouseActionsActions(@MouseControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_MouseActions_Mouse;
        public InputActionMap Get() { return m_Wrapper.m_MouseActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActionsActions instance)
        {
            if (m_Wrapper.m_MouseActionsActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnMouse;
            }
            m_Wrapper.m_MouseActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
            }
        }
    }
    public MouseActionsActions @MouseActions => new MouseActionsActions(this);
    public interface IMouseActionsActions
    {
        void OnMouse(InputAction.CallbackContext context);
    }
}
