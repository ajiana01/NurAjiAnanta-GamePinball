using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    private Renderer rendererAnim;
    private Animator animator;
    public AudioManager audioManager;
    public VFXManager vfxmanager;
    public ScoreManager scoreManager;
    public float score;

    private void Start() {
        rendererAnim = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        GetComponent<Renderer>().material.color = color;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("Hit");
            audioManager.PlaySFX(collision.transform.position);
            vfxmanager.PlayVFXBumper(collision.transform.position);
            scoreManager.AddScore(score);
        }
    }
    
}
