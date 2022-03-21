using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MoveList
{
    public string attackName;
    public int moveID;
    public int powerPoints;
    public int basePower;
    public int accuracy;

    public MoveList(string name, int moveID, int powerPoints, int basePower, int accuracy, MoveType movetype)
    {
        this.attackName = name;
        this.moveID = moveID;
        this.powerPoints = powerPoints;
        this.basePower = basePower;
        this.accuracy = accuracy;
        this.moveType = movetype;
    }

    public enum MoveType
    {
        Grass,
        Fire,
        Water,
        Rock,
        Ground,
        Flying,
        Fighting,
        Psychic,
        Ghost,
        Normal,
        Electric,
        Ice,
        Poison,
        Bug,
        Dragon,
        None
    }
    public MoveType moveType;

}
