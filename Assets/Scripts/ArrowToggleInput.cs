using UnityEngine;

public class ArrowToggleInput : MonoBehaviour
{
    [SerializeField] private TargetArrowPointer arrowPointer;

    void Update()
    {
        // A button on right controller
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            arrowPointer.NextTarget();
        }
    }
}
