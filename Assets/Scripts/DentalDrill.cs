using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DentalDrill : MonoBehaviour
{
    public int note = 64;
    public float amplitude = 0.5f;
    public bool drilling = false;

    private HapticController haptics;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        HapticController newHaptics = collision.gameObject.GetComponent<HapticController>();
        if (newHaptics != null) newHaptics = collision.gameObject.GetComponentInChildren<HapticController>();
        if (newHaptics != null) haptics = newHaptics;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (drilling) GetComponent<PickUpObjects>().VibrateHand(note, amplitude);
    }
}
