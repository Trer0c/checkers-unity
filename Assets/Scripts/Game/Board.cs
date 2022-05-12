using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Board : MonoBehaviour
{
    public static Board instance;
    public List<GameObject> tilesBoard = new List<GameObject>();
    [SerializeField] private Transform _board;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        InitBoard();
    }

    private void InitBoard()
    {
        if (tilesBoard.Count != 0)
        {
            tilesBoard.Clear();
        }
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            foreach (GameObject tile in _board)
            {
                tilesBoard.Add(tile);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            foreach (GameObject tile in _board)
            {
                tilesBoard.Add(tile);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            foreach (GameObject tile in _board)
            {
                tilesBoard.Add(tile);
            }
        }
    }
}

