using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class TransitionPoints : MonoBehaviour
{
    [SerializeField] Transform[] magneticPoints;
    [SerializeField] float snapDistance = 2.0f;

    private void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, snapDistance);

        foreach (Collider hitCollider in hitColliders)
        {
            TransitionPoints otherPoints = hitCollider.GetComponent<TransitionPoints>();
            if(otherPoints && otherPoints != this)
            {
                SnapToClosestPoint(otherPoints);
            }
        }
    }

    void SnapToClosestPoint(TransitionPoints otherPoints)
    {
        Transform closestPointThis = null;
        Transform closestPointOther = null;
        float closestDistance = float.MaxValue;

        foreach(Transform pointThis in magneticPoints)
        {
            foreach(Transform pointOther in otherPoints.magneticPoints)
            {
                float distance = Vector3.Distance(pointThis.position, pointOther.position);
                if(distance < closestDistance)
                {
                    closestDistance = distance;
                    closestPointThis = pointThis;
                    closestPointOther = pointOther;
                }
            }
        }

        if(closestPointThis && closestPointOther)
        {
            Vector3 directionToOther = closestPointOther.position - closestPointThis.position;
            transform.position += directionToOther;
            Debug.LogWarning("Snapping has happened");
        }
    }
}
