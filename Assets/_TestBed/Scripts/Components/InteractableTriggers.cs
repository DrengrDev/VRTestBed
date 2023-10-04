using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum InteractableTriggerID
{
    _1 = 1,
    _2 = 2,
    _3 = 3,
    _4 = 4
}

public class InteractableTriggers : MonoBehaviour
{
    public delegate void OnTriggerDelegate(GameObject triggerObject, int triggerId, GameObject grabbedItem = null);

    public enum TriggerMode
    {
        Touch,      //Trigger when user touches trigger collider
        Location,   //Trigger when user places object within range of trigger
        Manual      //Trigger activated by external script
    }

    #region Variables

    [Header("Trigger Settings")]
    public TriggerMode triggerMode;
    public InteractableTriggerID triggerID = InteractableTriggerID._1;

    public bool startDisabled = false;

    public List<string> allowedTriggerTags = new List<string>();
    [Space]
    [Range(.001f, .3f)] public float triggerActivationRange = .1f;

    [Tooltip("Automatically reset trigger state once fired.")]
    [Space]
    public bool autoReset;
    [Range(.1f, 1f)] public float triggerAutoResetDelay = .1f;

    public static event OnTriggerDelegate onTriggerEvent;
    public UnityEvent onTriggerUnityEvent;

    #endregion

    bool triggerActivated;
    bool touchTriggerActivated;
    bool locationTriggerActivated;
    bool manualTriggerActivated;

    //GameObject thats a grabbed item
    GameObject _target;

    Collider _collider;

    private void Start()
    {
        InitializeTrigger();
    }

    private void OnEnable()
    {
        InitializeTrigger();
    }

    private void Update()
    {
        if (triggerActivated && !autoReset) return;
        else if(triggerActivated && autoReset)
        {
            StartCoroutine(AutoResetTrigger());
        }
        else
        {
            if(triggerMode == TriggerMode.Location && _target != null)
            {
                LocationCheck();
            }

            CheckTriggerActivated();
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        Collider collider = c.gameObject.GetComponent<Collider>();
        if (collider)
        {
            touchTriggerActivated = true;
        }
    }

    public void SetTriggerMode(int mode)
    {
        triggerMode = (TriggerMode)mode;
    }

    private void LocationCheck()
    {
        Vector3 targetObjectPos = _target.gameObject.transform.position;
        float diff = Mathf.Abs((targetObjectPos - gameObject.transform.position).magnitude);

        if (diff <= triggerActivationRange)
        {
            locationTriggerActivated = true;
        }
    }

    void CheckTriggerActivated()
    {
        switch (triggerMode)
        {
            case TriggerMode.Touch:
                if (touchTriggerActivated) TriggerEvent();
                break;
            case TriggerMode.Location:
                if (locationTriggerActivated) TriggerEvent();
                break;
            case TriggerMode.Manual:
                if (manualTriggerActivated) TriggerEvent();
                break;
            default: break;
        }
    }

    void TriggerEvent()
    {
        if (triggerActivated) return;

        if (onTriggerEvent != null) onTriggerEvent.Invoke(gameObject, (byte)triggerID);
        if (onTriggerUnityEvent != null) onTriggerUnityEvent.Invoke();
        triggerActivated = true;
    }

    private void InitializeTrigger()
    {
        if(_collider == null)
        {
            _collider = GetComponent<Collider>();
        }

        if (startDisabled)
        {
            SetEnableTrigger(false);
        }
    }

    public void SetEnableTrigger(bool enable)
    {
        if (_collider != null) _collider.enabled = enable;
    }

    public void ResetTriggers()
    {
        triggerActivated = false;
        touchTriggerActivated = false;
        locationTriggerActivated = false;
        manualTriggerActivated = false;
        _target = null;
    }

    IEnumerator AutoResetTrigger()
    {
        yield return new WaitForSeconds(triggerAutoResetDelay);
        ResetTriggers();
    }
}