using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomChecker : MonoBehaviour
{

    private RoomManager RM;

    public UnityEvent EnterMaze;
    public UnityEvent ExitMaze;
    public UnityEvent EnterScare;
    public UnityEvent ExitScare;
    public UnityEvent EnterIllusion;
    public UnityEvent ExitIllusion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Maze Room"))
        {
            Debug.Log("Completed Maze room");
            EnterMaze.Invoke();
            RM.mainToMaze = false;
        }

        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Illusion Room"))
        {
            Debug.Log("Completed Illusion room");
            EnterIllusion.Invoke();
            RM.mainToIllusion = false;
        }

        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Scare Room"))
        {
            Debug.Log("Completed Scare room");
            EnterScare.Invoke();
            RM.mainToScare = false;
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Maze Room"))
        {
            Debug.Log("Completed Maze room");
            ExitMaze.Invoke();
        }

        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Illusion Room"))
        {
            Debug.Log("Completed Illusion room");
            ExitIllusion.Invoke();
        }

        if (other.CompareTag("playerCollider") && this.gameObject.CompareTag("Scare Room"))
        {
            Debug.Log("Completed Scare room");
            ExitScare.Invoke();
        }
    }*/
}
