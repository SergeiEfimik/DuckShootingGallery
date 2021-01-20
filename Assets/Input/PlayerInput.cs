// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5f63af33-48ee-4808-87c0-43a2199a13a2"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""5b796a15-87d3-429b-88f2-72b1abccab72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClickPosition"",
                    ""type"": ""Value"",
                    ""id"": ""a6229942-b5aa-429a-8095-dc3f5a3bfd92"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HorisontalDelta"",
                    ""type"": ""Value"",
                    ""id"": ""27b922cf-d13d-4304-821e-10ea2651a313"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Clamp(min=-5,max=5)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalDelta"",
                    ""type"": ""Value"",
                    ""id"": ""074a4f99-61c2-4769-b0a4-ec89c31a8f10"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Clamp(min=-5,max=5)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackButton"",
                    ""type"": ""Button"",
                    ""id"": ""802adf03-d6c3-43cf-92bf-f2e27f459eaf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ceffd74c-a06e-410e-b3dc-c4c6c5e3da46"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c19cd666-df12-4862-b31f-3ddca314a80f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d9d22ff-3ba4-4713-b97d-e309ce00c7bc"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""HorisontalDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8a27265-294d-450e-81d1-89939dbdfe26"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""HorisontalDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83914758-cc62-4b34-8edb-ddcd50081fc6"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""VerticalDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b427fc02-d8d7-401b-941e-2350fb7e11b6"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""VerticalDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3dce8f9f-715d-4f6d-ba50-ffbdb92bccdf"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""939725db-76fd-4b71-9bf6-91e95a287212"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""246621f7-56a0-4ada-80a6-d931a4dc72d8"",
                    ""path"": ""<Touchscreen>/touch1/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""AttackButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e97f90f-1537-4c8e-bcb1-a93f731bb3ac"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""AttackButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touchscreen"",
            ""bindingGroup"": ""Touchscreen"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Click = m_Player.FindAction("Click", throwIfNotFound: true);
        m_Player_ClickPosition = m_Player.FindAction("ClickPosition", throwIfNotFound: true);
        m_Player_HorisontalDelta = m_Player.FindAction("HorisontalDelta", throwIfNotFound: true);
        m_Player_VerticalDelta = m_Player.FindAction("VerticalDelta", throwIfNotFound: true);
        m_Player_AttackButton = m_Player.FindAction("AttackButton", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Click;
    private readonly InputAction m_Player_ClickPosition;
    private readonly InputAction m_Player_HorisontalDelta;
    private readonly InputAction m_Player_VerticalDelta;
    private readonly InputAction m_Player_AttackButton;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Player_Click;
        public InputAction @ClickPosition => m_Wrapper.m_Player_ClickPosition;
        public InputAction @HorisontalDelta => m_Wrapper.m_Player_HorisontalDelta;
        public InputAction @VerticalDelta => m_Wrapper.m_Player_VerticalDelta;
        public InputAction @AttackButton => m_Wrapper.m_Player_AttackButton;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @ClickPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClickPosition;
                @ClickPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClickPosition;
                @ClickPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClickPosition;
                @HorisontalDelta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorisontalDelta;
                @HorisontalDelta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorisontalDelta;
                @HorisontalDelta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorisontalDelta;
                @VerticalDelta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVerticalDelta;
                @VerticalDelta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVerticalDelta;
                @VerticalDelta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVerticalDelta;
                @AttackButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackButton;
                @AttackButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackButton;
                @AttackButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackButton;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ClickPosition.started += instance.OnClickPosition;
                @ClickPosition.performed += instance.OnClickPosition;
                @ClickPosition.canceled += instance.OnClickPosition;
                @HorisontalDelta.started += instance.OnHorisontalDelta;
                @HorisontalDelta.performed += instance.OnHorisontalDelta;
                @HorisontalDelta.canceled += instance.OnHorisontalDelta;
                @VerticalDelta.started += instance.OnVerticalDelta;
                @VerticalDelta.performed += instance.OnVerticalDelta;
                @VerticalDelta.canceled += instance.OnVerticalDelta;
                @AttackButton.started += instance.OnAttackButton;
                @AttackButton.performed += instance.OnAttackButton;
                @AttackButton.canceled += instance.OnAttackButton;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    private int m_TouchscreenSchemeIndex = -1;
    public InputControlScheme TouchscreenScheme
    {
        get
        {
            if (m_TouchscreenSchemeIndex == -1) m_TouchscreenSchemeIndex = asset.FindControlSchemeIndex("Touchscreen");
            return asset.controlSchemes[m_TouchscreenSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnClickPosition(InputAction.CallbackContext context);
        void OnHorisontalDelta(InputAction.CallbackContext context);
        void OnVerticalDelta(InputAction.CallbackContext context);
        void OnAttackButton(InputAction.CallbackContext context);
    }
}
