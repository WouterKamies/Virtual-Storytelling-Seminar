using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public Animator elevatorDoor;
    
    public bool elevatorStatus = false;
    public bool mazeStatus = false;
    public bool illusionStatus = false;
    public bool scareStatus = false;

    public float time;

    public void ElevatorComplete()
    {
        elevatorStatus = true;
    }

    public void MazeComplete()
    {
        mazeStatus = true;
    }

    public void IllusionComplete()
    {
        illusionStatus = true;
    }

    public void ScareComplete()
    {
        scareStatus = true;
    }

    public void UseElevator()
    {
        Debug.Log("ElevatorMusic.wav");
        StartCoroutine("waitOnElevator");
    }

    IEnumerator waitOnElevator()
    {
        yield return new WaitForSeconds(time);
        elevatorDoor.Play("Anim_doorOpen");

    }
}
