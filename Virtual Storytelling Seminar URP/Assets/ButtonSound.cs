using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    private bool isPressed;

    public AudioSource buttonAudio;
    public AudioClip buttonClip;

    private void Start()
    {
        isPressed = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            Debug.Log("Button Pressed");
            isPressed = true;
            buttonAudio.PlayOneShot(buttonClip);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            Debug.Log("Button Released");
            isPressed = false;
        }
    }

}
