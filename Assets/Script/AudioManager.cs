using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSrc;
    public GameObject sfxBumperAudioSrc;
    public GameObject sfxSwitchAudioSrc;
    void Start()
    {
        PlayBGM();
    }

    private void PlayBGM(){
        bgmAudioSrc.Play();
    }

    public void PlaySFX(Vector3 spawnPosition){
        GameObject.Instantiate(sfxBumperAudioSrc, spawnPosition, Quaternion.identity);
        Debug.Log("Play SFX Bumper");
    }
    public void PlaySFXSwitch(Vector3 spawnPosition){
        GameObject.Instantiate(sfxSwitchAudioSrc, spawnPosition, Quaternion.identity);
        Debug.Log("Play SFX Switch");
    }
}
