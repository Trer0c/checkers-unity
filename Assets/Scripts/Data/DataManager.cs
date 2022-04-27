using System;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public List<int> typeTileGameForOne = new List<int>();
    public List<int> typeTileGameForTwo = new List<int>();

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void InitData()
    {
        typeTileGameForOne = SaveManager.LoadTypeTileGameForOne();
        typeTileGameForTwo = SaveManager.LoadTypeTileGameForTwo();
    }
}

