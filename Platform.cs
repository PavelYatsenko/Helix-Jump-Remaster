using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    [SerializeField] private float _bouceForce;
    [SerializeField] private float _bouceRadius;


    public void Break()
    {
        PlatformSegment[]  platformSEgments = GetComponentsInChildren<PlatformSegment>();


        foreach(var segment in platformSEgments)
        {
            segment.Bouce(_bouceForce, transform.position, _bouceRadius);
        }

    }
}
 