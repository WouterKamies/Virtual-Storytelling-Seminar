using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class initializeFall : MonoBehaviour
{
    public UnityEvent fallSeuqence;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerCollider"))
        {
            Debug.Log("Timberrrrrrr");

            fallSeuqence.Invoke();
        }
    }
}
