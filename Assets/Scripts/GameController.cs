using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameController : StateMachine
{
    public CameraRig cameraRig;
    public Grid grid;
    public LevelData levelData;
    public Transform tileSelectionIndicator;
    public Point pos;
    
    public Tile currentTile
    {
        get { return grid.GetTile(pos);  }
    }

    void Start()
    {
        Debug.Log("Init State");
        ChangeState<InitGameState>();
    }
}