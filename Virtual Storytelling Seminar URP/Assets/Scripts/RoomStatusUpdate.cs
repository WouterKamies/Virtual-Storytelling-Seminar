using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomStatusUpdate : MonoBehaviour
{
    private RoomManager RM;

    public UnityEvent UpdateMaze;
    public UnityEvent UpdateElevator;
    public UnityEvent UpdateScare;
    public UnityEvent UpdateIllusion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Maze Room"))
        {
            Debug.Log("Completed Maze room");
            UpdateMaze.Invoke();
        }

        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Illusion Room"))
        {
            Debug.Log("Completed Illusion room");
            UpdateIllusion.Invoke();
        }

        if(other.CompareTag("playerCollider") && this.gameObject.CompareTag("Elevator"))
        {
            Debug.Log("Completed Elevator");
            UpdateElevator.Invoke();
        }

        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Scare Room"))
        {
            Debug.Log("Completed Scare room");
            UpdateScare.Invoke();
        }
    }
}
