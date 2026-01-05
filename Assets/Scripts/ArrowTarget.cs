using UnityEngine;

public class ArrowTarget : MonoBehaviour
{
    private void OnEnable()
    {
        if (TargetRegistry.Instance != null)
            TargetRegistry.Instance.Register(transform);
    }

    private void OnDisable()
    {
        if (TargetRegistry.Instance != null)
            TargetRegistry.Instance.Unregister(transform);
    }
}
