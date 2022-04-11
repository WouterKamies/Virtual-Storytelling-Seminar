using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DissableRoom : MonoBehaviour
{
    public RoomManager RM;

    public UnityEvent OnEnterFromElevator;
    public UnityEvent OnEnterFromMaze;
    public UnityEvent OnEnterFromIllusion;
    public UnityEvent OnEnterScare;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerCollider") /*&& RM.elevatorStatus == true*/)
        {
            Debug.Log("Exited Elevator");
            OnEnterFromElevator.Invoke();
        }

        if (other.CompareTag("playerCollider") && RM.mazeStatus == true)
        {
            Debug.Log("Exited Maze");
            OnEnterFromMaze.Invoke();
        }

        if (other.CompareTag("playerCollider") && RM.illusionStatus == true)
        {
            Debug.Log("Exited Illusion");
            OnEnterFromIllusion.Invoke();
        }

        if (other.CompareTag("playerCollider") && RM.scareStatus == true)
        {
            Debug.Log("Exited Scare");
            OnEnterScare.Invoke();
        }
    }
}
