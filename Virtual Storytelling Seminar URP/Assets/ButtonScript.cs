using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public UnityEvent OnPressed;
    private bool isPressed;

    private void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            Debug.Log("Button Pressed");
            OnPressed.Invoke();
            isPressed = true;
            this.gameObject.SetActive(false);
            Debug.Log("buttonInactive");
        }
    }
}
