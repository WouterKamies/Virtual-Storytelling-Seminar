using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomLoader : MonoBehaviour
{
    private RoomChecker RC;
    private RoomManager RM;

    public UnityEvent UnloadScare;
    public UnityEvent loadScare;

    public UnityEvent UnloadIllusion;
    public UnityEvent loadIllusion;

    public UnityEvent UnloadMaze;
    public UnityEvent loadMaze;

    public UnityEvent UnloadMain;
    public UnityEvent loadMain;

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
