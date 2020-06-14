// GENERATED AUTOMATICALLY FROM 'Assets/scripts/all the game/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Controller : IInputActionCollection
{
    private InputActionAsset asset;
    public Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""6f69aefb-8744-4996-96b8-cba52183d5af"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""id"": ""f061da00-239e-4142-903a-e6ab0b350463"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""attack"",
                    ""id"": ""7f16dc77-ed9f-47a6-aebd-c7fa5d7cc5a8"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""interact"",
                    ""id"": ""03690af4-6958-40a5-9d8f-6f570ae2a647"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""dodge"",
                    ""id"": ""0ebd34ac-4bda-4e32-ad92-8cc13adc9cd2"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""inventory"",
                    ""id"": ""16a71299-cde3-43dc-9f5c-40d60221fb87"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""sprint"",
                    ""id"": ""4f36faa0-1a1d-4d72-ac39-46b89bea9dee"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f15b8864-334a-433d-8178-bc728eef9de3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""68a9d32c-65c1-475f-a4cb-751e8fc26a03"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ca6c29d3-c532-4c03-860e-90fc6950d052"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""6c0422d5-29be-4682-9775-0ec42a1b378f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""c3ac3ea7-e9a5-40c9-a2f3-c708d1f5ab97"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""759faee3-4957-4a5b-9357-61862a4a74f3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""bf04aa88-aa7f-46a3-8545-bad57178fb83"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.GetActionMap("gameplay");
        m_gameplay_move = m_gameplay.GetAction("move");
        m_gameplay_attack = m_gameplay.GetAction("attack");
        m_gameplay_interact = m_gameplay.GetAction("interact");
        m_gameplay_dodge = m_gameplay.GetAction("dodge");
        m_gameplay_inventory = m_gameplay.GetAction("inventory");
        m_gameplay_sprint = m_gameplay.GetAction("sprint");
    }

    ~Controller()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }

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

    // gameplay
    private InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private InputAction m_gameplay_move;
    private InputAction m_gameplay_attack;
    private InputAction m_gameplay_interact;
    private InputAction m_gameplay_dodge;
    private InputAction m_gameplay_inventory;
    private InputAction m_gameplay_sprint;
    public struct GameplayActions
    {
        private Controller m_Wrapper;
        public GameplayActions(Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @move { get { return m_Wrapper.m_gameplay_move; } }
        public InputAction @attack { get { return m_Wrapper.m_gameplay_attack; } }
        public InputAction @interact { get { return m_Wrapper.m_gameplay_interact; } }
        public InputAction @dodge { get { return m_Wrapper.m_gameplay_dodge; } }
        public InputAction @inventory { get { return m_Wrapper.m_gameplay_inventory; } }
        public InputAction @sprint { get { return m_Wrapper.m_gameplay_sprint; } }
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                dodge.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDodge;
                dodge.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDodge;
                dodge.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDodge;
                inventory.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventory;
                inventory.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventory;
                inventory.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventory;
                sprint.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSprint;
                sprint.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSprint;
                sprint.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                move.started += instance.OnMove;
                move.performed += instance.OnMove;
                move.canceled += instance.OnMove;
                attack.started += instance.OnAttack;
                attack.performed += instance.OnAttack;
                attack.canceled += instance.OnAttack;
                interact.started += instance.OnInteract;
                interact.performed += instance.OnInteract;
                interact.canceled += instance.OnInteract;
                dodge.started += instance.OnDodge;
                dodge.performed += instance.OnDodge;
                dodge.canceled += instance.OnDodge;
                inventory.started += instance.OnInventory;
                inventory.performed += instance.OnInventory;
                inventory.canceled += instance.OnInventory;
                sprint.started += instance.OnSprint;
                sprint.performed += instance.OnSprint;
                sprint.canceled += instance.OnSprint;
            }
        }
    }
    public GameplayActions @gameplay
    {
        get
        {
            return new GameplayActions(this);
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
