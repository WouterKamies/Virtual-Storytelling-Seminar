using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomLoader : MonoBehaviour
{
    public RoomManager RM;
    public RoomLoader RL;

    public UnityEvent UnloadScare;
    public UnityEvent loadScare;

    public UnityEvent UnloadIllusion;
    public UnityEvent loadIllusion;

    public UnityEvent UnloadMaze;
    public UnityEvent loadMaze;

    public UnityEvent UnloadMain;
    public UnityEvent loadMain;

    public UnityEvent exitElevator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerCollider") && RM.mainToIllusion)
        {
            Debug.Log("Elevator going to illusion");
            UnloadMain.Invoke();
            loadIllusion.Invoke();
        }

        if (other.CompareTag("playerCollider") && RM.mainToMaze)
        {
            Debug.Log("Elevator going to maze");
            UnloadMain.Invoke();
            loadMaze.Invoke();
        }

        if (other.CompareTag("playerCollider") && RM.mainToScare)
        {
            Debug.Log("Going to scare");
            UnloadMain.Invoke();
            loadScare.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("playerCollider") && RM.mainToIllusion)
        {
            Debug.Log("Exited elevator");
            
        }

        if (other.CompareTag("playerCollider") && RM.mainToMaze)
        {
            Debug.Log("Exited elevator");
            RM.mainToMaze = false;
        }

        if (other.CompareTag("playerCollider") && RM.mainToScare)
        {
            Debug.Log("Exited elevator");
            RM.mainToScare = false;
        }
    }

    public void CheckElevatorExit()
    {
        if (RM.mazeStatus)
        {
            UnloadMaze.Invoke();
            loadMain.Invoke();
        }

        if (!RM.mazeStatus)
        {
            UnloadMain.Invoke();
        }


    }

}
