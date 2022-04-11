using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    //public Animator elevatorDoor;
    
    public bool mazeStatus = false;
    public bool illusionStatus = false;
    public bool scareStatus = false;

    public bool inMaze = false;
    public bool inIllusion = false;
    public bool inScare = false;

    public bool mainToMaze = false;
    public bool mainToIllusion = false;
    public bool mainToScare = false;

    //public float time;


    //=============MAZE===============
    public void MazeComplete()
    {
        Debug.Log("Completed Maze");
        mazeStatus = true;
    }

    public void EnterMaze()
    {
        Debug.Log("Entered Maze");
        inMaze = true;
    }
    public void ExitMaze()
    {
        Debug.Log("Exited Maze");
        inMaze = false;
    }

    public void MazeElevator()
    {
        Debug.Log("Ging to Maze");
        mainToMaze = true;
    }


    //=============ILLUSION===============
    public void IllusionComplete()
    {
        Debug.Log("Completed Illusion");
        illusionStatus = true;
    }

    public void EnterIllusion()
    {
        Debug.Log("Entered Illusion");
        inIllusion = true;
    }
    public void ExitIllusion()
    {
        Debug.Log("Exited Illusion");
        inIllusion = false;
    }

    public void IllusionElevator()
    {
        Debug.Log("Ging to Illusion");
        mainToIllusion = true;
    }

    //=============SCARE===============
    public void ScareComplete()
    {
        Debug.Log("Completed Scare");
        scareStatus = true;
    }

    public void EnterScare()
    {
        Debug.Log("Entered Illusion");
        inScare = true;
    }
    public void ExitScare()
    {
        Debug.Log("Exited Illusion");
        inScare = false;
    }
    public void ScareElevator()
    {
        Debug.Log("Ging to Scare");
        mainToScare = true;
    }

    //public void UseElevator()
    //{
    //Debug.Log("ElevatorMusic.wav");
    //StartCoroutine("waitOnElevator");
    //}

    //IEnumerator waitOnElevator()
    //{
    //yield return new WaitForSeconds(time);
    //elevatorDoor.Play("Anim_doorOpen");
    //}
}
