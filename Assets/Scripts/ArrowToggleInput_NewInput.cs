using UnityEngine;
using UnityEngine.InputSystem;

public class ArrowToggleInput_NewInput : MonoBehaviour
{
    [SerializeField] private TargetArrowPointer arrowPointer;
    [SerializeField] private InputActionReference toggleAction;

    private void OnEnable()
    {
        toggleAction.action.Enable();
        toggleAction.action.performed += OnToggle;
    }

    private void OnDisable()
    {
        toggleAction.action.performed -= OnToggle;
        toggleAction.action.Disable();
    }

    private void OnToggle(InputAction.CallbackContext context)
    {
        arrowPointer.NextTarget();
    }
}
