using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public AudioClip drillAudio;
    private AudioSource audioPlayer;
    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioPlayer.PlayOneShot(drillAudio);
    }

    private void OnTriggerStay(Collider other)
    {
        /*
        audioPlayer.PlayOneShot(drillAudio);

        if (other.CompareTag("Level1"))
            HapticManager.singleton.TriggerVibration(255,255,255, OVRInput.Controller.RTouch);

        if (other.CompareTag("Level2"))
            HapticManager.singleton.TriggerVibration(127,127, 127, OVRInput.Controller.RTouch);
        
        if (other.CompareTag("Level3"))
            HapticManager.singleton.TriggerVibration(63,63,63, OVRInput.Controller.RTouch);
        */

        //HapticManager.singleton.TriggerVibration(drillAudio, OVRInput.Controller.RTouch);
        HapticManager.singleton.TriggerVibration(40, 2, 255 , OVRInput.Controller.RTouch);
    }

    private void OnTriggerExit(Collider other)
    {
        audioPlayer.Stop();
        //OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }
}
