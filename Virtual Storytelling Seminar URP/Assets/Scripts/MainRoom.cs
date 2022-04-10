using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class MainRoom : MonoBehaviour
{
    public Transform MazeSnapPoint;
    public Transform IllusionSnapPoint;
    public Transform ScareSnapPoint;
    public Transform ElevatorSnapPoint;

    [Button]
    public void SnapToMaze()
    {
        transform.position = MazeSnapPoint.position;
        transform.right = MazeSnapPoint.right;
    }

    [Button]
    public void SnapToIllusion()
    {
        transform.position = IllusionSnapPoint.position;
        transform.right = IllusionSnapPoint.right;
    }

    [Button]
    public void SnapToScare()
    {
        transform.position = ScareSnapPoint.position;
        transform.right = ScareSnapPoint.right;
    }

    [Button]
    public void SnapToElevator()
    {
        transform.position = ElevatorSnapPoint.position;
        transform.right = ElevatorSnapPoint.right;
    }
}
