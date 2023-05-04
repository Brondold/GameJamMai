using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ParkingManager : MonoBehaviour
{
    public int Puzzle;
    public int GoalPuzzle;

    public void Add()
    {
        Puzzle += 1;
        if(Puzzle >=GoalPuzzle)
        {
            print("fin du puzzle");
        }
    }

}
