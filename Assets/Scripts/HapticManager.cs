using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticManager : MonoBehaviour
{
    public static HapticManager singleton;
    void Start()
    {
        if (singleton && singleton != this)
            Destroy(this);
        else
            singleton = this;
    }

    //Vibrate with audio file
    public void TriggerVibration(AudioClip vibrationAudio, OVRInput.Controller controller)
    {
        OVRHapticsClip clip = new OVRHapticsClip(vibrationAudio);

        if(controller == OVRInput.Controller.RTouch)
        {
            OVRHaptics.RightChannel.Mix(clip);
        }

    }

    //Vibrate without audio file
    public void TriggerVibration(int iteration, int frequency, int strength, OVRInput.Controller controller)
    {
        OVRHapticsClip clip = new OVRHapticsClip();
        for (int i = 0; i<iteration; i++){
            clip.WriteSample(i % frequency == 0 ? (byte)strength : (byte)0);
        }

        if (controller == OVRInput.Controller.RTouch)
        {
            OVRHaptics.RightChannel.Preempt(clip);
        }

    }

}
