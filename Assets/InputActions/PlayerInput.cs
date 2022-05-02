// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerInput.inputactions'

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
            ""id"": ""509bb1a0-68f6-4d06-87a6-cfe0c76145f6"",
            ""actions"": [
                {
                    ""name"": ""GoUp"",
                    ""type"": ""Button"",
                    ""id"": ""aafbd4c1-5d80-4fcb-a653-817be2eb5cac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoDown"",
                    ""type"": ""Button"",
                    ""id"": ""d814444c-6393-4edc-a396-a95204c77504"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a53fe085-284b-4a01-84f0-967c331185d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoRight"",
                    ""type"": ""Button"",
                    ""id"": ""76938d57-5a2d-4425-a38e-123dc41640b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""fd65b904-5a1e-4f7b-a92e-9a5ae5a764e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49273d17-ffc8-4eaa-923b-1d013c6dd1f8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cdbb4c8-b920-44c9-9ebf-802cf10b0f0f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7368cec-efa8-46ac-a433-66e5cb248517"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab457f06-45cf-489b-9284-1012c3abdb95"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3aa6cf37-20f3-47ea-b041-c0042f3d696e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10724772-7626-46df-86d4-c8b97a680900"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2133977-cd76-4760-b10e-13863e5938c5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98589ba8-bccc-4c47-8cb6-4cb306e57e92"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""GoRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d07a3447-acc2-4bc3-bd47-5f8982fc1429"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
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
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_GoUp = m_Player.FindAction("GoUp", throwIfNotFound: true);
        m_Player_GoDown = m_Player.FindAction("GoDown", throwIfNotFound: true);
        m_Player_GoLeft = m_Player.FindAction("GoLeft", throwIfNotFound: true);
        m_Player_GoRight = m_Player.FindAction("GoRight", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
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
    private readonly InputAction m_Player_GoUp;
    private readonly InputAction m_Player_GoDown;
    private readonly InputAction m_Player_GoLeft;
    private readonly InputAction m_Player_GoRight;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @GoUp => m_Wrapper.m_Player_GoUp;
        public InputAction @GoDown => m_Wrapper.m_Player_GoDown;
        public InputAction @GoLeft => m_Wrapper.m_Player_GoLeft;
        public InputAction @GoRight => m_Wrapper.m_Player_GoRight;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @GoUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoUp;
                @GoUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoUp;
                @GoUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoUp;
                @GoDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoDown;
                @GoDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoDown;
                @GoDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoDown;
                @GoLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoLeft;
                @GoLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoLeft;
                @GoLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoLeft;
                @GoRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoRight;
                @GoRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoRight;
                @GoRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGoRight;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GoUp.started += instance.OnGoUp;
                @GoUp.performed += instance.OnGoUp;
                @GoUp.canceled += instance.OnGoUp;
                @GoDown.started += instance.OnGoDown;
                @GoDown.performed += instance.OnGoDown;
                @GoDown.canceled += instance.OnGoDown;
                @GoLeft.started += instance.OnGoLeft;
                @GoLeft.performed += instance.OnGoLeft;
                @GoLeft.canceled += instance.OnGoLeft;
                @GoRight.started += instance.OnGoRight;
                @GoRight.performed += instance.OnGoRight;
                @GoRight.canceled += instance.OnGoRight;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
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
    public interface IPlayerActions
    {
        void OnGoUp(InputAction.CallbackContext context);
        void OnGoDown(InputAction.CallbackContext context);
        void OnGoLeft(InputAction.CallbackContext context);
        void OnGoRight(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
