using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;
    public float maxForce;
    public float maxTime;
    private bool isHold = false;
    public Color color;
    public Color color2;


    private void OnCollisionStay(Collision collision){
        if(collision.collider == bola) {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider) {
        if(Input.GetKey(input) && !isHold){
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider){
        isHold = true;
        float force = 0.0f;
        float timeHold = 0.0f;
        while(Input.GetKey(input)) {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTime);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
            GetComponent<Renderer>().material.color = color;
            Debug.Log("Force: " + force + "Time: " + timeHold);
        }
        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
        GetComponent<Renderer>().material.color = color2;
    }
}
