using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;

    private void Start(){
        ResetScore();
    }
    
    private void Update(){
    }
    public void AddScore(float addition) {
        score += addition;
        Debug.Log("Score add:" + score);
    }

    public void ResetScore() {
        score = 0;
    }
}
