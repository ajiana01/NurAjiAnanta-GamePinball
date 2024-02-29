using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode inputKey;
    private float targetPress;
    private float targetRelease;
    private HingeJoint hinge;

    void Start()
    {
       hinge = GetComponent<HingeJoint>();
       targetPress = hinge.limits.max;
       targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;
        if (Input.GetKey(inputKey))
        {
            jointSpring.targetPosition = targetPress;
        } 
        else
        {
            jointSpring.targetPosition = targetRelease;
        }
        hinge.spring = jointSpring;
    }
}
