// GENERATED AUTOMATICALLY FROM 'Assets/NewInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewInput"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""7ccc3b10-b4e1-4bf2-9fd4-adcc68f13355"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b2a38927-e430-4d5b-9445-d00bed26450b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b4e97385-9977-4aa6-b857-355bb0df8dc9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5ea6b498-546d-4ee0-a748-f0b5b2f8e7f6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""e731a827-923d-4eb7-a8af-212c84aa69dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""b8d0eb42-f9b1-4cd0-8cff-4b762efbdea4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9d77a09c-fad8-4cce-b19b-601f07b77328"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""296a2e56-40a6-4584-b466-c4217e7b6493"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1681ab4d-21cd-4a8d-ad49-e95f1d789b09"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2493ad44-b862-481c-9829-f895c755db60"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfab843d-f266-4e69-bbee-79ae11c321c1"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c99d4822-57d4-433d-bd1c-2e2af967c163"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
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
        }
    ]
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Click = m_GamePlay.FindAction("Click", throwIfNotFound: true);
        m_GamePlay_RightClick = m_GamePlay.FindAction("RightClick", throwIfNotFound: true);
        m_GamePlay_Point = m_GamePlay.FindAction("Point", throwIfNotFound: true);
        m_GamePlay_Cancel = m_GamePlay.FindAction("Cancel", throwIfNotFound: true);
        m_GamePlay_Submit = m_GamePlay.FindAction("Submit", throwIfNotFound: true);
        m_GamePlay_MiddleClick = m_GamePlay.FindAction("MiddleClick", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Click;
    private readonly InputAction m_GamePlay_RightClick;
    private readonly InputAction m_GamePlay_Point;
    private readonly InputAction m_GamePlay_Cancel;
    private readonly InputAction m_GamePlay_Submit;
    private readonly InputAction m_GamePlay_MiddleClick;
    public struct GamePlayActions
    {
        private @NewInput m_Wrapper;
        public GamePlayActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_GamePlay_Click;
        public InputAction @RightClick => m_Wrapper.m_GamePlay_RightClick;
        public InputAction @Point => m_Wrapper.m_GamePlay_Point;
        public InputAction @Cancel => m_Wrapper.m_GamePlay_Cancel;
        public InputAction @Submit => m_Wrapper.m_GamePlay_Submit;
        public InputAction @MiddleClick => m_Wrapper.m_GamePlay_MiddleClick;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClick;
                @RightClick.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightClick;
                @Point.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPoint;
                @Cancel.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCancel;
                @Submit.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSubmit;
                @MiddleClick.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMiddleClick;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
    public interface IGamePlayActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
    }
}
