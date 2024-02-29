using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScoreRamp : MonoBehaviour
{
    public float score;
    public ScoreManager scoreManager;
    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola) {
            scoreManager.AddScore(score);
        }
    }
}
