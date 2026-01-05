using UnityEngine;

public class TargetArrowPointer : MonoBehaviour
{
    [SerializeField] private Transform userCamera;
    [SerializeField] private Transform arrow;
    [SerializeField] private float arrowDistance = 0.5f;

    private int currentIndex = 0;

    void Update()
    {
        var targets = TargetRegistry.Instance.Targets;
        if (targets.Count == 0)
            return;

        if (currentIndex >= targets.Count)
            currentIndex = 0;

        Transform target = targets[currentIndex];
        if (target == null)
            return;

        arrow.position = userCamera.position + userCamera.forward * arrowDistance;
        Vector3 dir = (target.position - arrow.position).normalized;
        arrow.rotation = Quaternion.LookRotation(dir, Vector3.up);
    }

    public void NextTarget()
    {
        var targets = TargetRegistry.Instance.Targets;
        if (targets.Count == 0)
            return;

        currentIndex = (currentIndex + 1) % targets.Count;
    }
}
