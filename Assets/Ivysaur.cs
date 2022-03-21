using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ivysaur : AbstractPokemon
{
    public MoveListDataBase moveListDatabase;
    public MoveList[] moveSet;
    public Dictionary<int, MoveList> bulbasaurMoveList = new Dictionary<int, MoveList>();
    public Dictionary<string, int> levelUpStats = new Dictionary<string, int>();
    public MoveList movechosen;
    public string moveTypeSelected;
    public EnemyPokemon enemypokemon;
    public Bulbasaur bulbasaur;
    public GameObject bulbasaurObject;

    public override void Evolve()
    {
        return;
    }

    public void EvolveCheck()
    {
        if (currentLevel == 32)
        {
            Evolve();
            Debug.Log("Evolving");
        }
    }

    private void Start()
    {
        bulbasaurObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateStatIncrease();
            MoveSet();
        }
    }

    public void GenerateStatIncrease()
    {
        
            levelUpStats.Add("maxHP", Random.Range(2, 6));
            levelUpStats.Add("attack", Random.Range(2, 6));
            levelUpStats.Add("defense", Random.Range(2, 6));
            levelUpStats.Add("specialAttack", Random.Range(2, 6));
            levelUpStats.Add("specialDefense", Random.Range(2, 6));
            levelUpStats.Add("speed", Random.Range(2, 6));
            LevelUp(1);
        
    }

    public override void LevelUp(int level)
    {

        currentLevel += level;
        maxHP += levelUpStats["maxHP"];
        attack += levelUpStats["attack"];
        defense += levelUpStats["defense"];
        specialAttack += levelUpStats["specialAttack"];
        specialDefense += levelUpStats["specialDefense"];
        speed += levelUpStats["speed"];

        EvolveCheck();
        levelUpStats.Clear();

        Debug.Log("maxHP = " + maxHP);
        Debug.Log("attack = " + attack);
        Debug.Log("defense = " + defense);
        Debug.Log("specialAttack = " + specialAttack);
        Debug.Log("specialDefense = " + specialDefense);
        Debug.Log("speed = " + speed);
    }

    public void MoveSet()
    {
        moveSet[0] = moveListDatabase.moveList["Tackle"];
        if (currentLevel == 9)
        {
            moveSet[1] = moveListDatabase.moveList["Leech Seed"];
        }
        if (currentLevel == 13)
        {
            moveSet[2] = moveListDatabase.moveList["Vine Whip"];
        }
    }

    void MoveChoosen(MoveList moveChosen)
    {
        movechosen = moveChosen;
        moveTypeSelected = moveChosen.moveType.ToString();
    }

    void AttackCheck()
    {
        if (moveTypeSelected == pokemonType1.ToString() || moveTypeSelected == pokemonType2.ToString())
        {
            if (moveTypeSelected != enemypokemon.pokemonType1.ToString() || moveTypeSelected != enemypokemon.pokemonType2.ToString() && moveTypeSelected != enemypokemon.weaknessType1.ToString() && moveTypeSelected != enemypokemon.weaknessType2.ToString() && moveTypeSelected != enemypokemon.weaknessType3.ToString() && moveTypeSelected != enemypokemon.weaknessType4.ToString())
            {
                Attack((float)(movechosen.basePower * 1.5));
            }
            else if (moveTypeSelected == enemypokemon.pokemonType1.ToString() || moveTypeSelected == enemypokemon.pokemonType2.ToString())
            {
                Attack(1);
            }
        }
        if (moveTypeSelected != pokemonType1.ToString() || moveTypeSelected != pokemonType2.ToString())
        {
            if (moveTypeSelected == enemypokemon.pokemonType1.ToString() || moveTypeSelected == enemypokemon.pokemonType2.ToString())
            {
                Attack((float)(movechosen.basePower * .5));
            }
            if (moveTypeSelected != enemypokemon.pokemonType1.ToString() || moveTypeSelected != enemypokemon.pokemonType2.ToString() && moveTypeSelected == enemypokemon.weaknessType1.ToString() && moveTypeSelected == enemypokemon.weaknessType2.ToString() && moveTypeSelected == enemypokemon.weaknessType3.ToString() && moveTypeSelected == enemypokemon.weaknessType4.ToString())
            {
                Attack((float)(movechosen.basePower * 2));
            }
        }
    }

    void Attack(float attackMultiplyer)
    {
        attack += attackMultiplyer;
    }
}
