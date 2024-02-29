using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState {
        On,
        Off,
        Blink
    };
    public Collider bola;
    public Material onMaterial;
    public Material offMaterial;
    private Renderer render;
    private SwitchState state;
    public ScoreManager scoreManager;
    public float score;
    public AudioManager audioManager;
    public VFXManager vfxmanager;

    private void Start(){
        render = GetComponent<Renderer>();
        Set(false);
        StartCoroutine(BlinkStartTimer(5));
    }

    private void OnTriggerEnter(Collider other){
        if (other==bola){
            Toggle();
        }
    }

    private void Set(bool active){
        if(active == true) {
            state = SwitchState.On;
            render.material = onMaterial;
            StopAllCoroutines();
        } else {
            state = SwitchState.Off;
            render.material = offMaterial;
            StartCoroutine(BlinkStartTimer(5));
        }
    }

    private void Toggle() {
        if(state == SwitchState.On){
            Set(false);
        } else {
            Set(true);
        }
        audioManager.PlaySFXSwitch(transform.position);
        vfxmanager.PlayVFXSwitch(transform.position);
        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int times) {
        state = SwitchState.Blink;
        for(int i=0; i < times; i++ ){
            render.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            render.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.Off;
        StartCoroutine(BlinkStartTimer(5));
    }

    private IEnumerator BlinkStartTimer(float time){
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
