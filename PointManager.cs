using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{  
    public int totalPoints;
    public int pressurePlatePoints;

    [Header("LevelTwo2D")]
    public int yellowHexPoint;
    public int redHexPoint;

    public void AddScore(int point)
    {
        totalPoints += point;  
    }

    public void AddPointHexMaze(int point)
    {
        totalPoints += point;
    }

    public void AddPointHexPressurePlate(int point)
    {
        pressurePlatePoints += point;
    }
    public void AddYellowHexPoint(int point)
    {
        yellowHexPoint += point;
    }

    public void AddRedHexPoint(int point)
    {
        redHexPoint += point;
    }

}

