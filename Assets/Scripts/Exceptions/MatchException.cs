using UnityEngine;
using System.Collections;

public class MatchException : BaseException 
{
    public readonly Player offense;
    public readonly Player defense;

    public MatchException (Player offense, Player defense) : base (false)
    {
        this.offense = offense;
        this.defense = defense;
    }
}