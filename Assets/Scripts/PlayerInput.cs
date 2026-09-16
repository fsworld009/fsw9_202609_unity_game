using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    private CharacterHealth ch;
    private CharacterDamage cd;
    private void OnEnable()
    {
        // Subscribe to the global action change event
        InputSystem.onActionChange += OnActionChanged;


        InputAction jumpAction = InputSystem.actions.FindAction("Jump");
        jumpAction.started += OnJump;

        ch = GetComponent<CharacterHealth>();
        cd = GetComponent<CharacterDamage>();
    }

    private void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        InputSystem.onActionChange -= OnActionChanged;


        InputAction jumpAction = InputSystem.actions.FindAction("Jump");
        jumpAction.started -= OnJump;
    }

    private void Update()
    {
        if (ch.IsDead() || cd.IsInKnockback()) return;

        InputAction moveAction = InputSystem.actions.FindAction("Move");
        if (moveAction != null && moveAction.IsPressed())
        {
            Vector2 moveInput = moveAction.ReadValue<Vector2>();
            Vector3 moveDir = new Vector3(moveInput.x, 0f, moveInput.y);
            GetComponent<CharacterMove>().Move(moveDir);
        }

        InputAction lookAction = InputSystem.actions.FindAction("Look");
        if (lookAction != null && lookAction.IsPressed())
        {
            Vector2 lookInput = lookAction.ReadValue<Vector2>();
            Vector3 rotateDir = new Vector3(0, 90 * lookInput.x, 0);

            GetComponent<CharacterMove>().Rotate(rotateDir);
        }

        InputAction attackAction = InputSystem.actions.FindAction("Attack");
        if (attackAction != null && attackAction.IsPressed())
        {
            GetComponent<CharacterShoot>().Shoot();
        }
    }

    private void OnActionChanged(object obj, InputActionChange change)
    {
        return;
        // Check if the change event belongs to an individual action
        if (obj is InputAction action)
        {
            if (action.actionMap.name == "Player") { 
                switch (change)
                {
                    case InputActionChange.ActionStarted:
                        Debug.Log($"Action started: {action.name}");
                        break;
                    case InputActionChange.ActionPerformed:
                        Debug.Log($"Action performed: {action.name}. Value: {action.ReadValueAsObject()}");
                        break;
                    case InputActionChange.ActionCanceled:
                        Debug.Log($"Action canceled: {action.name}");
                        break;
                }

            }
        }
        // Check if the change event belongs to an action map
        else if (obj is InputActionMap actionMap)
        {
            if (change == InputActionChange.ActionMapEnabled)
            {
                Debug.Log($"Action Map enabled: {actionMap.name}");
            }
        }
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        if (ch.IsDead() || cd.IsInKnockback()) return;
        GetComponent<CharacterJump>().Jump();
    }
}
