using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InitGameState : GameState
{
    public override void Enter()
    {
        base.Enter();
        StartCoroutine(Init());
    }

    IEnumerator Init ()
    {
        grid.Load( levelData );
        Point p = new Point((int)levelData.tiles[0].x, (int)levelData.tiles[0].z);
        SelectTile(p);
        yield return null;
    }
}