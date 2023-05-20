using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapManager : MonoBehaviour
{
    public OVRCameraRig camera1;

    public GameObject[] camPositions;

    private Transform[] transforms;
    private int index = 0;

    private void Awake()
    {
        camera1.transform.position = camPositions[0].transform.position;

        transforms = new Transform[camPositions.Length];

        for(int i = 0; i < camPositions.Length; i++)
        {
            transforms[i] = camPositions[i].transform;
        }
    }

    public void ChangePosition()
    {
        index++;

        if(index >= transforms.Length)
        {
            index = 0;
            camera1.transform.position = transforms[index].position;
        }
        else
        {
            camera1.transform.position = transforms[index].position;
        }
    }
}
