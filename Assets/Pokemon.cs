using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
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

    public Pokemon(string name, int id, int currentLevel, int maxHP, float attack, float defense, int specialAttack, int specialDefense, int speed, PokemonType pokemonType1, PokemonType pokemonType2)
    {
        this.pokemonName = name;
        this.id = id;
        this.currentLevel = currentLevel;
        this.maxHP = maxHP;
        this.attack = attack;
        this.defense = defense;
        this.specialAttack = specialAttack;
        this.specialDefense = specialDefense;
        this.speed = speed;
        this.pokemonType1 = pokemonType1;
        this.pokemonType2 = pokemonType2;
    }

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

}
