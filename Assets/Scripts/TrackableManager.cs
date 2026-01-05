using Meta.XR.MRUtilityKit;
using UnityEngine;

public class TrackableManager : MonoBehaviour
{
    [SerializeField] private GameObject trackObjectPrefab;
   

    public void OnTrackableAdded(MRUKTrackable trackable)
    {
        Debug.Log($"Trackable Type: {trackable.TrackableType} added");
        Instantiate(trackObjectPrefab, trackable.transform);
    }

    public void OnTrackableRemoved(MRUKTrackable trackable)
    {
        Debug.Log($"Trackable Type: {trackable.TrackableType} removed");
        Destroy(trackable.gameObject);
    }
}
