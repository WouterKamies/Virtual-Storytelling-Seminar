using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScareRoomSequence : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager GM;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerCollider"))
        {
            Debug.Log("player entered center");
            GM.StartFallSequence();
        }
        
    }
}
