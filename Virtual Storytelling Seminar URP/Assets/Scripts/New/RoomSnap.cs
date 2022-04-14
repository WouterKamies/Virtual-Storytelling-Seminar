using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class RoomSnap : MonoBehaviour
{
    public Transform ElevatorExit;
    
    public Transform MazeDoor;
    public Transform MazeExit;
    public Transform IllusionDoor;
    public Transform IllusionExit;
    public Transform ScareDoor;
    public Transform ScareRoomExit;

    public Transform ReturnDoor;

    
    
    

    //ELEVATOR
    [Button]
    public void SnapToElevatorExit()
    {
        transform.position = ElevatorExit.position;
        transform.right = ElevatorExit.right;
        Debug.Log("Snapped to elevator exit");
    }

    //MAZE ROOM
    [Button]
    public void SnapToMainMaze()
    {
        transform.position = MazeDoor.position;
        transform.right = MazeDoor.right;
    }

    [Button]
    public void SnapToMazeExit()
    {
        transform.position = MazeExit.position;
        transform.right = MazeExit.right;
    }

    //ILLUSION ROOM
    [Button]
    public void SnapToMainIllusion()
    {
        transform.position = IllusionDoor.position;
        transform.right = IllusionDoor.right;
    }

    [Button]
    public void SnapToIllusionRoomExit()
    {
        transform.position = IllusionExit.position;
        transform.right = IllusionExit.right;
    }

    //SCARE ROOM
    [Button]
    public void SnapToMainScare()
    {
        transform.position = ScareDoor.position;
        transform.right = ScareDoor.right;
    }

    [Button]
    public void SnapToScareRoomExit()
    {
        transform.position = ScareRoomExit.position;
        transform.right = ScareRoomExit.right;
    }

    //RETURN DOOR
    [Button]
    public void SnapToReturn()
    {
        transform.position = ReturnDoor.position;
        transform.right = ReturnDoor.right;
    }
}
