// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""blau"",
            ""id"": ""e5cfcbef-6177-4889-b779-e30ac63a768f"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ce2c939a-39e9-415d-b484-b15144856991"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cb494444-8630-4567-bab4-e6cc3fb6ce11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""eebb7430-ce7e-4119-a69b-92952ce5e3ca"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""19d2ba27-c6c1-442e-97ec-3d3aaffe3468"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""36271e3e-dddc-4744-bdb0-f3e12b39d75a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5971ed38-6ee0-43f4-bb21-01ba90cfa28b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard;gamepad"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""rot"",
            ""id"": ""ae3e7b0c-4aab-4a05-821a-5ecbe2afd321"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5dbca0ce-f8f1-45f6-8397-70d4f5aac7f8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b916d226-99df-4b84-ad5b-9034efc49b67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""bf18a1f1-fcdb-42e0-bf0e-60b9505e300a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ea4c9351-e4d0-4a4d-8762-a26af38086bc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18db3c4b-233f-4d03-ab51-93b0f6b497ff"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c13bbcbd-9a3c-4270-915d-0f097bd75d50"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""gamepad"",
            ""bindingGroup"": ""gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": []
        }
    ]
}");
        // blau
        m_blau = asset.FindActionMap("blau", throwIfNotFound: true);
        m_blau_move = m_blau.FindAction("move", throwIfNotFound: true);
        m_blau_jump = m_blau.FindAction("jump", throwIfNotFound: true);
        // rot
        m_rot = asset.FindActionMap("rot", throwIfNotFound: true);
        m_rot_move = m_rot.FindAction("move", throwIfNotFound: true);
        m_rot_jump = m_rot.FindAction("jump", throwIfNotFound: true);
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

    // blau
    private readonly InputActionMap m_blau;
    private IBlauActions m_BlauActionsCallbackInterface;
    private readonly InputAction m_blau_move;
    private readonly InputAction m_blau_jump;
    public struct BlauActions
    {
        private @PlayerInputActions m_Wrapper;
        public BlauActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_blau_move;
        public InputAction @jump => m_Wrapper.m_blau_jump;
        public InputActionMap Get() { return m_Wrapper.m_blau; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BlauActions set) { return set.Get(); }
        public void SetCallbacks(IBlauActions instance)
        {
            if (m_Wrapper.m_BlauActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_BlauActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_BlauActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_BlauActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_BlauActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_BlauActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_BlauActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BlauActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public BlauActions @blau => new BlauActions(this);

    // rot
    private readonly InputActionMap m_rot;
    private IRotActions m_RotActionsCallbackInterface;
    private readonly InputAction m_rot_move;
    private readonly InputAction m_rot_jump;
    public struct RotActions
    {
        private @PlayerInputActions m_Wrapper;
        public RotActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_rot_move;
        public InputAction @jump => m_Wrapper.m_rot_jump;
        public InputActionMap Get() { return m_Wrapper.m_rot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotActions set) { return set.Get(); }
        public void SetCallbacks(IRotActions instance)
        {
            if (m_Wrapper.m_RotActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_RotActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_RotActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_RotActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_RotActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_RotActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_RotActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_RotActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public RotActions @rot => new RotActions(this);
    private int m_gamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_gamepadSchemeIndex == -1) m_gamepadSchemeIndex = asset.FindControlSchemeIndex("gamepad");
            return asset.controlSchemes[m_gamepadSchemeIndex];
        }
    }
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    public interface IBlauActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IRotActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
