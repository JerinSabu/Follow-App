using System.Collections.Generic;
using UnityEngine;

public class TargetRegistry : MonoBehaviour
{
    public static TargetRegistry Instance;

    private readonly List<Transform> targets = new List<Transform>();

    public IReadOnlyList<Transform> Targets => targets;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Register(Transform target)
    {
        if (!targets.Contains(target))
            targets.Add(target);
    }

    public void Unregister(Transform target)
    {
        targets.Remove(target);
    }
}
