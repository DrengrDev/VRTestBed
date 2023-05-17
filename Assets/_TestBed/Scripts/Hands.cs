using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class Hands : MonoBehaviour
{
    public Transform palm;
    public float reachDistance = 0.1f, joinDistance = 0.05f;
    public LayerMask grabbableObjectLayer;

    Rigidbody body;
    
    bool _rightHand;
    bool _isGrabbing;

    private GameObject _heldObject;
    private Transform _grabPoint;
    private Transform _followTarget;

    private FixedJoint joint1, joint2;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        body.collisionDetectionMode = CollisionDetectionMode.Continuous;
        body.interpolation = RigidbodyInterpolation.Interpolate;
        body.mass = 20f;
        body.maxAngularVelocity = 20f;

        HandCheck();
    }

    private void OnEnable()
    {
        if (_rightHand)
        {
            InputManager.interactionOnGrabRightStartEvent += GrabCheck; //Grab;
            InputManager.interactionOnGrabRightCanceledEvent += ReleaseItem;
        }
        else
        {
            InputManager.interactionOnGrabLeftStartEvent += GrabCheck;  //Grab;
            InputManager.interactionOnGrabLeftCanceledEvent += ReleaseItem ;
        }
    }

    private void OnDisable()
    {
        if (_rightHand)
        {
            InputManager.interactionOnGrabRightStartEvent -= GrabCheck; //Grab;
            InputManager.interactionOnGrabRightCanceledEvent -= ReleaseItem;
        }
        else
        {
            InputManager.interactionOnGrabLeftStartEvent -= GrabCheck;  //Grab;
            InputManager.interactionOnGrabLeftCanceledEvent -= ReleaseItem;
        }
    }

    void HandCheck()
    {
        if (gameObject.CompareTag("RightHand")) _rightHand = true;
    }

    /*void HandPhysics()
    {
        //Position
        Vector3 positionWithOffset = _followTarget.TransformPoint(positionOffset);
        float distance = Vector3.Distance(positionWithOffset, transform.position);
        body.velocity = (positionWithOffset - transform.position).normalized *(followSpeed * distance);

        //Rotation
        Quaternion rotationWithOffset = _followTarget.rotation * Quaternion.Euler(rotationOffset);
        Quaternion q = rotationWithOffset * Quaternion.Inverse(body.rotation);
        q.ToAngleAxis(out float angle, out Vector3 axis);
        body.angularVelocity = axis * (angle * Mathf.Deg2Rad * rotateSpeed);
    }*/

    void GrabCheck()
    {
        if (_isGrabbing || _heldObject) return;

        Collider[] grabbableColliders = Physics.OverlapSphere(palm.position, reachDistance, grabbableObjectLayer);
        if (grabbableColliders.Length < 1) return;

        GameObject objectToGrab = grabbableColliders[0].transform.gameObject;
        Rigidbody objectRigidbody = objectToGrab.GetComponent<Rigidbody>();
        
        if (objectRigidbody != null)
        {
            _heldObject = objectRigidbody.gameObject;
        }
        else
        {
            objectRigidbody = objectToGrab.GetComponentInParent<Rigidbody>();
            if (objectRigidbody != null) _heldObject = objectRigidbody.gameObject;
            else
            {
                return;
            }
        }
        StartCoroutine(GrabObject(grabbableColliders[0], objectRigidbody));
    }

    void ReleaseItem()
    {
        if (joint1 != null) Destroy(joint1);
        if (joint2 != null) Destroy(joint2);
        if (_grabPoint != null) Destroy(_grabPoint.gameObject);

        if (_heldObject != null)
        {
            Rigidbody targetBody = _heldObject.GetComponent<Rigidbody>();
            targetBody.collisionDetectionMode = CollisionDetectionMode.Discrete;
            targetBody.interpolation = RigidbodyInterpolation.None;
            _heldObject = null;
        }

        _isGrabbing = false;
    }



    IEnumerator GrabObject(Collider collider, Rigidbody objectRigidbody)
    {
        _isGrabbing = true;

        //Create a grab point
        _grabPoint = new GameObject().transform;
        _grabPoint.position = collider.ClosestPoint(palm.position);
        _grabPoint.parent = _heldObject.transform;

        //Move Hand To Grab Point
        

        //Wait for hand to reach grab point

        while(Vector3.Distance(_grabPoint.position, palm.position) >joinDistance && _isGrabbing)
        {
            yield return new WaitForEndOfFrame();
        }

        //Freeze hand and object motion

        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        objectRigidbody.velocity = Vector3.zero;
        objectRigidbody.angularVelocity = Vector3.zero;

        objectRigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        objectRigidbody.interpolation = RigidbodyInterpolation.Interpolate;

        //Attach joints

        joint1 = gameObject.AddComponent<FixedJoint>();
        joint1.connectedBody = objectRigidbody;
        joint1.breakForce = float.PositiveInfinity;
        joint1.breakTorque = float.PositiveInfinity;

        joint1.connectedMassScale = 1;
        joint1.massScale = 1;
        joint1.enableCollision = false;
        joint1.enablePreprocessing = false;

        joint2 = _heldObject.AddComponent<FixedJoint>();
        joint2.connectedBody = body;
        joint2.breakForce = float.PositiveInfinity;
        joint2.breakTorque = float.PositiveInfinity;

        joint2.connectedMassScale = 1;
        joint2.massScale = 1;
        joint2.enableCollision = false;
        joint2.enablePreprocessing = false;

        //Reset follow target

    }
}
