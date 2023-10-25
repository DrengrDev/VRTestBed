using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    //Reference to the snap point transform
    public Transform snapPoint;

    private bool isSnapped = false;

    //Reference to the Rigidbody component
    private Rigidbody body;

    private void Start()
    {
        //Cache the Rigidbody component if it exists
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isSnapped)
        {
            TrySnapToPosition();
        }
    }

    public void TrySnapToPosition()
    {
        if (snapPoint == null)
        {
            Debug.LogError("Snap point transform is not assigned for " + gameObject.name);
            return;
        }

        //Check if the snap point is within a certain distance
        float snapDistance = 0.1f;
        if(Vector3.Distance(transform.position, snapPoint.position) < snapDistance)
        {
            SnapToPosition();
        }
    }

    public void SnapToPosition()
    {
        //Snap the object to the snap point position and rotation
        transform.position = snapPoint.position;
        transform.rotation = snapPoint.rotation;

        //Optionally, disable rigidbody physics to prevent further movement
        if(body != null)
        {
            body.isKinematic = true;
        }

        isSnapped = true;

        //Optionally, play a sound or particle effect for feedback
    }
}
