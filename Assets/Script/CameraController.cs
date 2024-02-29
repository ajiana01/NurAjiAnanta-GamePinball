using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float returnTime;
    public float followSpeed;
    public float length;
    private Vector3 defaultPosition;
    public bool hasTarget { get {return target != null;}}

    private void Start() {
        defaultPosition = transform.position;
        target = null;
    }

    private void Update() {
        if( hasTarget) {
        Vector3 targetCameraDirection = transform.rotation * -Vector3.forward;
        Vector3 targetPosition = target.position + (targetCameraDirection * length);
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed* Time.deltaTime);
        }
    }

    public void FollowOnTarget(Transform targetTransform, float targetLength) {
        StopAllCoroutines();
        target = targetTransform;
        length = targetLength;
    }

    public void GoBackDefault() {
        target = null;
        StopAllCoroutines();
        StartCoroutine(MovePosition(defaultPosition, 2));
    }

    private IEnumerator MovePosition(Vector3 target, float time){
        float timer = 0;
        Vector3 start = transform.position;
        while (timer<time) {
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0, 1f,timer/time));
            timer +=Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = target;
    }
}
