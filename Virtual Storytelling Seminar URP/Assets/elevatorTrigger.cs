using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class elevatorTrigger : MonoBehaviour
{
    public RoomStatus RS;
    public GameManager GM;

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("playerCollider"))
        {
            GM.UseElevator();
        }
            
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("playerCollider"))
        {
            GM.LeaveElevator();
        }
    }
}
