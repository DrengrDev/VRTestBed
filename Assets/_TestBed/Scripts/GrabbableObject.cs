using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    Hands _currentHand;

    bool _itemGrabbed;

    public bool Grab(Hands parentHand)
    {
        if (!_itemGrabbed)
        {
            _currentHand = parentHand;
            _itemGrabbed = true;
            gameObject.transform.position = parentHand.transform.position;
            gameObject.transform.rotation = parentHand.transform.rotation;

            gameObject.transform.parent = _currentHand.transform;

            return true;
        }
        else
        {
            return false;
        }
    }
}
