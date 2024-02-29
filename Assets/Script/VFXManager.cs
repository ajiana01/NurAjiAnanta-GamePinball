using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxBumperSrc;
    public GameObject vfxSwitchSrc;
    public void PlayVFXBumper(Vector3 spawnPosition){
        GameObject.Instantiate(vfxBumperSrc, spawnPosition, Quaternion.identity);
        Debug.Log("Ini VFX BUMPER");
    }
    public void PlayVFXSwitch(Vector3 spawnPosition){
        GameObject.Instantiate(vfxSwitchSrc, spawnPosition, Quaternion.identity);
        Debug.Log("Ini VFX SWITCHH");
    }
}
