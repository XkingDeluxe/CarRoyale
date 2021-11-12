// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Inputs/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""89c42d23-0f4b-43b3-a503-67dd048c4a3f"",
            ""actions"": [
                {
                    ""name"": ""Gas"",
                    ""type"": ""Button"",
                    ""id"": ""e60c1360-173b-433b-b3c9-e743a0f9dbf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""54ba859d-d8b7-4724-9597-64ebfa17a19e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""e0d51180-241a-4f50-b943-ef541666230b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""16bb0e00-aaf1-49ba-b182-bd564a1e92b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ready"",
                    ""type"": ""Button"",
                    ""id"": ""83fbfe4f-afd1-4780-861e-159c9cc8bd5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""561efbdf-4b9f-4325-a0f3-0764fceaa700"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""94bc681d-21fc-4e58-8f47-68e108b61c2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cUp"",
                    ""type"": ""Button"",
                    ""id"": ""8deca91b-3d20-43ec-a44a-04b155397ae9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cDown"",
                    ""type"": ""Button"",
                    ""id"": ""1163060e-f3e6-4666-b754-c1c22704ac18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cLeft"",
                    ""type"": ""Button"",
                    ""id"": ""93b26c9d-8355-4a33-959a-9a489fe931aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cRight"",
                    ""type"": ""Button"",
                    ""id"": ""d9cec39b-be46-4f99-83b3-340372133462"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cBack"",
                    ""type"": ""Button"",
                    ""id"": ""3aa65b2f-f5f7-4efb-b317-2bf3ee4ed811"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""7fbe5b94-1cfb-454c-8b26-f07b6f331506"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c86a4e66-c00d-4054-9523-a3a4491ac383"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ed383fe-cd47-4a63-ad7a-d451c8205148"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c371dc06-62b2-4be2-8682-702f1d02763e"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f412d3f-2539-4e53-94c6-cb4103f64208"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77631f32-836f-4429-a14c-bc648e45fc00"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11ebadf1-0d7a-4ee1-a56c-504dc7eb9034"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e39a47ab-dad7-4bfd-9dc9-4035119a3951"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51176130-2f1e-44f5-b8c6-2751959f601b"",
                    ""path"": ""<DualShockGamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fb1894f-4823-457e-a406-ee44c7841efa"",
                    ""path"": ""<DualShockGamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fa71cd5-3568-4e7b-9bea-6eadcfbcb750"",
                    ""path"": ""<DualShockGamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c197717c-df7e-4597-870e-ec8a8e9a8c97"",
                    ""path"": ""<DualShockGamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4439dad5-efaf-4e42-b1e3-737145d01a4d"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd7b8154-d433-4bcf-a789-bfca12864c15"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""ba39ca01-4d0f-4ede-984d-24e9baaf4c2f"",
            ""actions"": [
                {
                    ""name"": ""Gas"",
                    ""type"": ""Button"",
                    ""id"": ""c1217c34-87a8-457a-9bde-789e3a3e4df2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""3b58a43a-de53-44d6-9c7b-4dec1c631e6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""6e26c862-aa1c-4325-915e-d0cbc22dfab3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""0cf48e33-7056-4ce5-a5b7-8e69a36be052"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ready"",
                    ""type"": ""Button"",
                    ""id"": ""ffd59bfb-3875-4cec-adf7-2ee9e4d841bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""51b4773f-17d2-4eb7-84e2-8aacca153b13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""1c4253f5-6118-419f-9228-f20785a016f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cUp"",
                    ""type"": ""Button"",
                    ""id"": ""f3962c7c-144e-499f-8dd2-ba4fce000225"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cDown"",
                    ""type"": ""Button"",
                    ""id"": ""0d0c84a3-6195-49ae-a6da-fa72dd9bbfe0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cLeft"",
                    ""type"": ""Button"",
                    ""id"": ""78c2a01d-082c-4166-b962-ffa9671c7af7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cRight"",
                    ""type"": ""Button"",
                    ""id"": ""a65dcf01-8f70-4262-8d2f-a71b3fa32b97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cBack"",
                    ""type"": ""Button"",
                    ""id"": ""38e6dd30-0825-43c5-a855-d1d18e5d56fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33974dda-0c9b-43d3-bcba-81bea3dd9212"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d74fada6-c573-4322-a9fa-5ade0e3317b6"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c43af246-d0f1-4b3e-b542-3a2567ce9528"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""130347df-e536-4d72-8d16-1ad49e8562e3"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4b16b17-f07a-4133-8b31-27a57d1fc441"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""867df184-2c6d-4149-90ee-375a6762955e"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96880415-a368-4f33-86bd-760fd147dddb"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed3560c0-bcac-494a-943a-a127072413f7"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4be2ca1-f9be-45d0-a050-a60e5b20bcf5"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd8c9cae-09df-480e-b748-4cb8901ea236"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70b61aec-8566-4a2f-9b78-7c7620b25f99"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""412a7ab4-bd20-4ee4-b7d4-b6ac0df962a9"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_Gas = m_PlayerOne.FindAction("Gas", throwIfNotFound: true);
        m_PlayerOne_Back = m_PlayerOne.FindAction("Back", throwIfNotFound: true);
        m_PlayerOne_Left = m_PlayerOne.FindAction("Left", throwIfNotFound: true);
        m_PlayerOne_Right = m_PlayerOne.FindAction("Right", throwIfNotFound: true);
        m_PlayerOne_Ready = m_PlayerOne.FindAction("Ready", throwIfNotFound: true);
        m_PlayerOne_Boost = m_PlayerOne.FindAction("Boost", throwIfNotFound: true);
        m_PlayerOne_Reset = m_PlayerOne.FindAction("Reset", throwIfNotFound: true);
        m_PlayerOne_cUp = m_PlayerOne.FindAction("cUp", throwIfNotFound: true);
        m_PlayerOne_cDown = m_PlayerOne.FindAction("cDown", throwIfNotFound: true);
        m_PlayerOne_cLeft = m_PlayerOne.FindAction("cLeft", throwIfNotFound: true);
        m_PlayerOne_cRight = m_PlayerOne.FindAction("cRight", throwIfNotFound: true);
        m_PlayerOne_cBack = m_PlayerOne.FindAction("cBack", throwIfNotFound: true);
        m_PlayerOne_Options = m_PlayerOne.FindAction("Options", throwIfNotFound: true);
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_Gas = m_PlayerTwo.FindAction("Gas", throwIfNotFound: true);
        m_PlayerTwo_Back = m_PlayerTwo.FindAction("Back", throwIfNotFound: true);
        m_PlayerTwo_Left = m_PlayerTwo.FindAction("Left", throwIfNotFound: true);
        m_PlayerTwo_Right = m_PlayerTwo.FindAction("Right", throwIfNotFound: true);
        m_PlayerTwo_Ready = m_PlayerTwo.FindAction("Ready", throwIfNotFound: true);
        m_PlayerTwo_Boost = m_PlayerTwo.FindAction("Boost", throwIfNotFound: true);
        m_PlayerTwo_Reset = m_PlayerTwo.FindAction("Reset", throwIfNotFound: true);
        m_PlayerTwo_cUp = m_PlayerTwo.FindAction("cUp", throwIfNotFound: true);
        m_PlayerTwo_cDown = m_PlayerTwo.FindAction("cDown", throwIfNotFound: true);
        m_PlayerTwo_cLeft = m_PlayerTwo.FindAction("cLeft", throwIfNotFound: true);
        m_PlayerTwo_cRight = m_PlayerTwo.FindAction("cRight", throwIfNotFound: true);
        m_PlayerTwo_cBack = m_PlayerTwo.FindAction("cBack", throwIfNotFound: true);
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

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_Gas;
    private readonly InputAction m_PlayerOne_Back;
    private readonly InputAction m_PlayerOne_Left;
    private readonly InputAction m_PlayerOne_Right;
    private readonly InputAction m_PlayerOne_Ready;
    private readonly InputAction m_PlayerOne_Boost;
    private readonly InputAction m_PlayerOne_Reset;
    private readonly InputAction m_PlayerOne_cUp;
    private readonly InputAction m_PlayerOne_cDown;
    private readonly InputAction m_PlayerOne_cLeft;
    private readonly InputAction m_PlayerOne_cRight;
    private readonly InputAction m_PlayerOne_cBack;
    private readonly InputAction m_PlayerOne_Options;
    public struct PlayerOneActions
    {
        private @Inputs m_Wrapper;
        public PlayerOneActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Gas => m_Wrapper.m_PlayerOne_Gas;
        public InputAction @Back => m_Wrapper.m_PlayerOne_Back;
        public InputAction @Left => m_Wrapper.m_PlayerOne_Left;
        public InputAction @Right => m_Wrapper.m_PlayerOne_Right;
        public InputAction @Ready => m_Wrapper.m_PlayerOne_Ready;
        public InputAction @Boost => m_Wrapper.m_PlayerOne_Boost;
        public InputAction @Reset => m_Wrapper.m_PlayerOne_Reset;
        public InputAction @cUp => m_Wrapper.m_PlayerOne_cUp;
        public InputAction @cDown => m_Wrapper.m_PlayerOne_cDown;
        public InputAction @cLeft => m_Wrapper.m_PlayerOne_cLeft;
        public InputAction @cRight => m_Wrapper.m_PlayerOne_cRight;
        public InputAction @cBack => m_Wrapper.m_PlayerOne_cBack;
        public InputAction @Options => m_Wrapper.m_PlayerOne_Options;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @Gas.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnGas;
                @Gas.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnGas;
                @Gas.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnGas;
                @Back.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnBack;
                @Left.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRight;
                @Ready.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnReady;
                @Ready.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnReady;
                @Ready.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnReady;
                @Boost.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnBoost;
                @Reset.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnReset;
                @cUp.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCUp;
                @cUp.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCUp;
                @cUp.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCUp;
                @cDown.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCDown;
                @cDown.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCDown;
                @cDown.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCDown;
                @cLeft.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCLeft;
                @cLeft.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCLeft;
                @cLeft.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCLeft;
                @cRight.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCRight;
                @cRight.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCRight;
                @cRight.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCRight;
                @cBack.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCBack;
                @cBack.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCBack;
                @cBack.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnCBack;
                @Options.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnOptions;
                @Options.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnOptions;
                @Options.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnOptions;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Gas.started += instance.OnGas;
                @Gas.performed += instance.OnGas;
                @Gas.canceled += instance.OnGas;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Ready.started += instance.OnReady;
                @Ready.performed += instance.OnReady;
                @Ready.canceled += instance.OnReady;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @cUp.started += instance.OnCUp;
                @cUp.performed += instance.OnCUp;
                @cUp.canceled += instance.OnCUp;
                @cDown.started += instance.OnCDown;
                @cDown.performed += instance.OnCDown;
                @cDown.canceled += instance.OnCDown;
                @cLeft.started += instance.OnCLeft;
                @cLeft.performed += instance.OnCLeft;
                @cLeft.canceled += instance.OnCLeft;
                @cRight.started += instance.OnCRight;
                @cRight.performed += instance.OnCRight;
                @cRight.canceled += instance.OnCRight;
                @cBack.started += instance.OnCBack;
                @cBack.performed += instance.OnCBack;
                @cBack.canceled += instance.OnCBack;
                @Options.started += instance.OnOptions;
                @Options.performed += instance.OnOptions;
                @Options.canceled += instance.OnOptions;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_Gas;
    private readonly InputAction m_PlayerTwo_Back;
    private readonly InputAction m_PlayerTwo_Left;
    private readonly InputAction m_PlayerTwo_Right;
    private readonly InputAction m_PlayerTwo_Ready;
    private readonly InputAction m_PlayerTwo_Boost;
    private readonly InputAction m_PlayerTwo_Reset;
    private readonly InputAction m_PlayerTwo_cUp;
    private readonly InputAction m_PlayerTwo_cDown;
    private readonly InputAction m_PlayerTwo_cLeft;
    private readonly InputAction m_PlayerTwo_cRight;
    private readonly InputAction m_PlayerTwo_cBack;
    public struct PlayerTwoActions
    {
        private @Inputs m_Wrapper;
        public PlayerTwoActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Gas => m_Wrapper.m_PlayerTwo_Gas;
        public InputAction @Back => m_Wrapper.m_PlayerTwo_Back;
        public InputAction @Left => m_Wrapper.m_PlayerTwo_Left;
        public InputAction @Right => m_Wrapper.m_PlayerTwo_Right;
        public InputAction @Ready => m_Wrapper.m_PlayerTwo_Ready;
        public InputAction @Boost => m_Wrapper.m_PlayerTwo_Boost;
        public InputAction @Reset => m_Wrapper.m_PlayerTwo_Reset;
        public InputAction @cUp => m_Wrapper.m_PlayerTwo_cUp;
        public InputAction @cDown => m_Wrapper.m_PlayerTwo_cDown;
        public InputAction @cLeft => m_Wrapper.m_PlayerTwo_cLeft;
        public InputAction @cRight => m_Wrapper.m_PlayerTwo_cRight;
        public InputAction @cBack => m_Wrapper.m_PlayerTwo_cBack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterface != null)
            {
                @Gas.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnGas;
                @Gas.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnGas;
                @Gas.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnGas;
                @Back.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnBack;
                @Left.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRight;
                @Ready.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnReady;
                @Ready.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnReady;
                @Ready.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnReady;
                @Boost.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnBoost;
                @Reset.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnReset;
                @cUp.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCUp;
                @cUp.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCUp;
                @cUp.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCUp;
                @cDown.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCDown;
                @cDown.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCDown;
                @cDown.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCDown;
                @cLeft.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCLeft;
                @cLeft.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCLeft;
                @cLeft.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCLeft;
                @cRight.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCRight;
                @cRight.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCRight;
                @cRight.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCRight;
                @cBack.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCBack;
                @cBack.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCBack;
                @cBack.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnCBack;
            }
            m_Wrapper.m_PlayerTwoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Gas.started += instance.OnGas;
                @Gas.performed += instance.OnGas;
                @Gas.canceled += instance.OnGas;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Ready.started += instance.OnReady;
                @Ready.performed += instance.OnReady;
                @Ready.canceled += instance.OnReady;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @cUp.started += instance.OnCUp;
                @cUp.performed += instance.OnCUp;
                @cUp.canceled += instance.OnCUp;
                @cDown.started += instance.OnCDown;
                @cDown.performed += instance.OnCDown;
                @cDown.canceled += instance.OnCDown;
                @cLeft.started += instance.OnCLeft;
                @cLeft.performed += instance.OnCLeft;
                @cLeft.canceled += instance.OnCLeft;
                @cRight.started += instance.OnCRight;
                @cRight.performed += instance.OnCRight;
                @cRight.canceled += instance.OnCRight;
                @cBack.started += instance.OnCBack;
                @cBack.performed += instance.OnCBack;
                @cBack.canceled += instance.OnCBack;
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);
    public interface IPlayerOneActions
    {
        void OnGas(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnReady(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnCUp(InputAction.CallbackContext context);
        void OnCDown(InputAction.CallbackContext context);
        void OnCLeft(InputAction.CallbackContext context);
        void OnCRight(InputAction.CallbackContext context);
        void OnCBack(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoActions
    {
        void OnGas(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnReady(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnCUp(InputAction.CallbackContext context);
        void OnCDown(InputAction.CallbackContext context);
        void OnCLeft(InputAction.CallbackContext context);
        void OnCRight(InputAction.CallbackContext context);
        void OnCBack(InputAction.CallbackContext context);
    }
}
