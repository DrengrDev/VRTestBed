using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpTagController : MonoBehaviour
{
    public Text tagText;
    
    [Space]

    private string cameraTag = "MainCamera";
    private Camera mainCamera;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        LookForCamera();
    }

    private void LookForCamera()
    {
        if (!mainCamera)
        {
            GameObject playerCameraObj = GameObject.FindGameObjectWithTag(cameraTag);
            if (!playerCameraObj) return;

            mainCamera = playerCameraObj.GetComponent<Camera>();
            if (!mainCamera) return;
        }
        gameObject.transform.LookAt(mainCamera.gameObject.transform);
    }
}
