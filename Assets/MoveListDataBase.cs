using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveListDataBase : MonoBehaviour
{
    public Dictionary<string, MoveList> moveList = new Dictionary<string, MoveList>();

    void Awake()
    {
        //Move List Params          ("name", ID, powerPoints, basePower, Accuracy, movetype)
        MoveList Tackle = new MoveList("Tackle", 1, 35, 40, 100, MoveList.MoveType.Normal);
        MoveList LeechSeed = new MoveList("Leech Seed", 2, 10, 0, 90, MoveList.MoveType.Grass);
        MoveList VineWhip = new MoveList("Vine Whip", 3, 25, 45, 100, MoveList.MoveType.Grass);
        MoveList Growl = new MoveList("Growl", 4, 40, 0, 100, MoveList.MoveType.Normal);
        MoveList TailWhip = new MoveList("Tail Whip", 5, 30, 0, 100, MoveList.MoveType.Normal);
        MoveList WaterGun = new MoveList("Water Gun", 6, 25, 40, 100, MoveList.MoveType.Water);
        MoveList Scratch = new MoveList("Scratch", 7, 35, 40, 100, MoveList.MoveType.Normal);
        MoveList Ember = new MoveList("Ember", 8, 25, 40, 100, MoveList.MoveType.Fire);
        MoveList SandAttack = new MoveList("Sand Attack", 9, 15, 0, 100, MoveList.MoveType.Ground);

        moveList.Add("Tackle", Tackle);
        moveList.Add("Leech Seed", LeechSeed);
        moveList.Add("Vine Whip", VineWhip);
        moveList.Add("Growl", Growl);
        moveList.Add("Tail Whip", TailWhip);
        moveList.Add("Water Gun", WaterGun);
        moveList.Add("Scratch", Scratch);
        moveList.Add("Ember", Ember);
        moveList.Add("Sand Attack", SandAttack);
    }
}
