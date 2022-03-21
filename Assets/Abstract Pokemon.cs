using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractPokemon : MonoBehaviour
{
    public string pokemonName;
    public int id;
    public int currentLevel;
    public int maxHP;
    public int currentHP;
    public float attack;
    public float defense;
    public int specialAttack;
    public int specialDefense;
    public int speed;
    public int currentEXP;
    public int maxEXP;
    public MoveList[] availableMoves;
    public enum PokemonType
    {
        None,
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
        Grass
    }

    public PokemonType pokemonType1;
    public PokemonType pokemonType2;
    public PokemonType weaknessType1;
    public PokemonType weaknessType2;
    public PokemonType weaknessType3;
    public PokemonType weaknessType4;



    public abstract void LevelUp(int level);

    public abstract void Evolve();

}
