using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public RoomStatus RS;
    
    public float waitTime = 5f;

    public AudioSource AS_elevatorCalled;
    public AudioSource AS_elevatorUsed;
    public AudioSource AS_elevatorDoor;
    public AudioSource AS_buzzer;
    public AudioSource AS_elevatorMusic;
    public AudioSource AS_Gnomed;

    public AudioClip A_ElevatorAmbience;
    public AudioClip A_ElevatorDoorClose;
    public AudioClip A_buzzer;
    public AudioClip A_elevatorMusic;
    public AudioClip A_Gnomed;

    public GameObject elevatorExitDoorVis;
    public GameObject elevatorEntryDoorVis;
    public GameObject mainRoof;
    public GameObject bridge;

    public Animator elevatorEntryDoor;
    public Animator elevatorExitDoor;
    public Animator scareRoomHatch;
    public Animator mainRoom;
    public Animator scareRoom;

    public UnityEvent loadMaze;
    public UnityEvent loadIllusion;
    public UnityEvent loadScare;
    public UnityEvent loadMain;
    public UnityEvent loadMainFromScare;
    public UnityEvent unloadMain;
    public UnityEvent unloadScare;

    public UnityEvent enterMaze;
    public UnityEvent enterMain;
    public UnityEvent enterScare;
    public UnityEvent enterIllusion;

    public UnityEvent fallingFromScare;
    public UnityEvent hideButtons;
    public UnityEvent showButtons;

    private void Start()
    {
        elevatorExitDoorVis.SetActive(false);
        elevatorEntryDoorVis.SetActive(true);
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fog = false;
    }

    public void LoadMaze()
    {
        loadMaze.Invoke();
    }

    public void LoadIllusion()
    {
        loadIllusion.Invoke();
    }

    public void LoadScare()
    {
        loadScare.Invoke();
    }

    public void LoadMain()
    {
        loadMain.Invoke();
    }

    public void CallElevator()
    {
        Debug.Log("Called elevator");
        StartCoroutine(elevatorCallSequence());
    }

    public void UseElevator()
    {
        Debug.Log("In Elevator");
        StartCoroutine(elevatorUseSequence());
    }

    public void LeaveElevator()
    {
        StartCoroutine(elevatorLeaveSequence());

    }

    public void StartFallSequence()
    {
        StartCoroutine(fallSequence());
    }

    public void Gnomed()
    {
        StartCoroutine(gnomed());
    }

    IEnumerator elevatorCallSequence()
    {
        //elevatorEntryDoorVis.SetActive(true);
        //elevatorExitDoorVis.SetActive(false);
        elevatorEntryDoor.Play("Idle");
        AS_elevatorCalled.PlayOneShot(A_ElevatorAmbience);
        yield return new WaitForSeconds(waitTime);
        AS_elevatorMusic.PlayOneShot(A_elevatorMusic);
        elevatorEntryDoor.Play("Anim_DoorOpen");
        Debug.Log("Elevator Arrived");

    }

    IEnumerator elevatorUseSequence()
    {
        RenderSettings.fog = false;
        elevatorExitDoorVis.SetActive(true);
        yield return new WaitForSeconds(2f);
        elevatorEntryDoor.Play("Anim_DoorClose");
        AS_elevatorDoor.PlayOneShot(A_ElevatorDoorClose);
        yield return new WaitForSeconds(2.5f);
        unloadMain.Invoke();
        if (RS.nextMAZE == true)
        {
            loadMaze.Invoke();
            Debug.Log("Loaded Maze");
        }

        if(RS.nextRETURN == true)
        {
            loadMain.Invoke();
            Debug.Log("Loaded Main");
        }

        if (RS.nextILLUSION == true)
        {
            loadIllusion.Invoke();
            Debug.Log("Loaded Illusion");
        }

        if (RS.nextSCARE == true)
        {
            loadScare.Invoke();
            Debug.Log("Loaded Scare");
            RenderSettings.fog = true;
            hideButtons.Invoke();
        }

        AS_elevatorUsed.PlayOneShot(A_ElevatorAmbience);
        yield return new WaitForSeconds(15f);
        elevatorExitDoor.Play("Anim_DoorOpen");

    }

    IEnumerator elevatorLeaveSequence()
    {
        yield return new WaitForSeconds(1f);
        elevatorExitDoor.Play("Anim_DoorClose");
        AS_elevatorMusic.Stop();
        AS_elevatorDoor.PlayOneShot(A_ElevatorDoorClose);
        if (RS.nextMAZE == true)
        {
            enterMaze.Invoke();
            Debug.Log("Entered Maze");
        }

        if (RS.nextRETURN == true)
        {
            enterMain.Invoke();
            RS.nextRETURN = false;
            Debug.Log("Entered Main");
        }

        if (RS.nextSCARE == true)
        {
            enterScare.Invoke();
            RS.nextSCARE = false;
            Debug.Log("Entered Scare");
        }
        

    }

    IEnumerator fallSequence()
    {
        bridge.SetActive(false);
        yield return new WaitForSeconds(20f);
        AS_buzzer.PlayOneShot(A_buzzer);
        loadMainFromScare.Invoke();
        mainRoof.SetActive(false);
        Debug.Log("Loaded main");

        yield return new WaitForSeconds(1.9f);
        scareRoomHatch.Play("Anim_OpenHatch");
        Debug.Log("commence fall");
        fallingFromScare.Invoke();

        yield return new WaitForSeconds(2);
        RS.CompletedScare();
        RS.nextRETURN = false;
        Debug.Log("Completed Scare");

        yield return new WaitForSeconds(5f);
        mainRoof.SetActive(true);
        unloadScare.Invoke();
        showButtons.Invoke();
    }

    IEnumerator gnomed()
    {
        yield return new WaitForSeconds(1.5f);
        AS_Gnomed.PlayOneShot(A_Gnomed);
        Debug.Log("youve been gnomed");

    }
}
