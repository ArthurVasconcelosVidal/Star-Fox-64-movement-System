// GENERATED AUTOMATICALLY FROM 'Assets/Input System/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Moviment"",
            ""id"": ""1ab20feb-18a4-4ed0-910c-a101faf4f738"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7c3abe07-eb18-4f90-951f-369483d08fc1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9bae77c9-22a1-4855-8c3b-336d6b06e2eb"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""77a03584-af27-4954-a4b4-891555dcd65f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""89f63191-0c2a-404f-bf09-b2575b80286e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c1568f00-997f-4d50-a4d2-be4f627cf4a5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50189ccc-54ce-4bab-bb4d-cd7ef482862b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""08f670fd-2c24-464b-919f-626900eabf84"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""5ccc9d33-05ba-4312-9804-25757b98a654"",
            ""actions"": [
                {
                    ""name"": ""ActionButton"",
                    ""type"": ""Button"",
                    ""id"": ""4cc6edfb-37d7-44d2-a945-008b92c5d485"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7cd6e272-4e20-408d-bca9-4984d3da1b32"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4186a93-26a0-4611-ae38-2e6e937e7ef2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Moviment
        m_Moviment = asset.FindActionMap("Moviment", throwIfNotFound: true);
        m_Moviment_Move = m_Moviment.FindAction("Move", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_ActionButton = m_Actions.FindAction("ActionButton", throwIfNotFound: true);
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

    // Moviment
    private readonly InputActionMap m_Moviment;
    private IMovimentActions m_MovimentActionsCallbackInterface;
    private readonly InputAction m_Moviment_Move;
    public struct MovimentActions
    {
        private @PlayerControl m_Wrapper;
        public MovimentActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Moviment_Move;
        public InputActionMap Get() { return m_Wrapper.m_Moviment; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovimentActions set) { return set.Get(); }
        public void SetCallbacks(IMovimentActions instance)
        {
            if (m_Wrapper.m_MovimentActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovimentActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovimentActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovimentActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovimentActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovimentActions @Moviment => new MovimentActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_ActionButton;
    public struct ActionsActions
    {
        private @PlayerControl m_Wrapper;
        public ActionsActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActionButton => m_Wrapper.m_Actions_ActionButton;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @ActionButton.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnActionButton;
                @ActionButton.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnActionButton;
                @ActionButton.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnActionButton;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ActionButton.started += instance.OnActionButton;
                @ActionButton.performed += instance.OnActionButton;
                @ActionButton.canceled += instance.OnActionButton;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
    public interface IMovimentActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnActionButton(InputAction.CallbackContext context);
    }
}
