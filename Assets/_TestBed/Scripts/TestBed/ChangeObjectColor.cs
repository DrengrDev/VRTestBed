using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectColor : MonoBehaviour
{
    public Color modifiedColor;

    private MeshRenderer render;
    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        render.material.color = modifiedColor;
    }
}
