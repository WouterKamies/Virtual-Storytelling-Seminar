using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomStatus : MonoBehaviour
{
    public GameManager GM;

    public bool nextMAZE;
    public bool nextILLUSION;
    public bool nextSCARE;
    public bool nextRETURN;

    public bool inMAZE;
    public bool inILLUSION;
    public bool inSCARE;

    public bool completedMAZE;
    public bool completedILLUSION;
    public bool completedSCARE;

    private void Start()
    {
        nextMAZE = false;
        nextILLUSION = false;
        nextSCARE = false;
        nextRETURN = false;

        inMAZE = false;
        inILLUSION = false;
        inSCARE = false;

        completedMAZE = false;
        completedILLUSION = false;
        completedSCARE = false;
    }
    //Next Room Functions
    public void NextMaze()
    {
        nextMAZE = true;
    }

    public void NextIllusion()
    {
        nextILLUSION = true;
    }

    public void NextScare()
    {
        nextSCARE = true;
    }

    public void NextReturn()
    {
        nextRETURN = true;
    }

    public void CompletedMaze()
    {
        completedMAZE = true;
        nextMAZE = false;
        nextRETURN = true;
    }

    public void CompletedIllusion()
    {
        completedILLUSION = true;
        nextILLUSION = false;
        nextRETURN = true;
    }

    public void CompletedScare()
    {
        completedSCARE = true;
        nextSCARE = false;
        nextRETURN = true;
    }

    //room complete functions
    public void CheckCompletedRoom()
    {
        if (inMAZE)
        {
            GM.LoadMaze();
            //completedMAZE = true;
            //nextRETURN = true;
        }

        if (inILLUSION)
        {
            inILLUSION = false;
            //completedILLUSION = true;
            //nextRETURN = true;
        }

        if (inSCARE)
        {
            inSCARE = false;
            //completedSCARE = true;
            //nextRETURN = true;
        }
    }

    //Entered room functions
    public void CheckEnteredRoom()
    {
        if (nextMAZE)
        {
            nextMAZE = false;
            //nextRETURN = true;
        }

        if (nextILLUSION)
        {
            nextILLUSION = false;
            //inILLUSION = true;
            //nextRETURN = true;
        }

        if (nextSCARE)
        {
            nextSCARE = false;
            //inSCARE = true;
            //nextRETURN = true;
        }



    }
}
