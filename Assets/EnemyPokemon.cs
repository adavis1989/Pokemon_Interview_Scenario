using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPokemon : AbstractPokemon
{
    public PokemonDatabase pokemonDatabase;
    public Pokemon pokemon;
    public int randomPokemonSelector;
    public string pokemonKey;
    public override void Evolve()
    {
        return;
    }

    public override void LevelUp(int level)
    {
        return;
    }

    private void Start()
    {
        randomPokemonSelector = Random.Range(1, 4);
        if (randomPokemonSelector == 1)
        {
            pokemonKey = "Squirtle";
        }
        else if (randomPokemonSelector == 2)
        {
            pokemonKey = "Charmander";
        }
        else if (randomPokemonSelector == 3)
        {
            pokemonKey = "Pidgey";
        }

        pokemon = pokemonDatabase.pokemonList[pokemonKey];
        SetStats();
    }
    public void SetStats()
    {
        pokemonName = pokemon.pokemonName;
        id = pokemon.id;
        currentLevel = pokemon.currentLevel;
        maxHP = pokemon.maxHP;
        currentHP = pokemon.maxHP;
        attack = pokemon.attack;
        defense = pokemon.defense;
        specialAttack = pokemon.specialAttack;
        specialDefense = pokemon.specialDefense;
        speed = pokemon.speed;
        pokemonType1 = (PokemonType)pokemon.pokemonType1;
        pokemonType2 = (PokemonType)pokemon.pokemonType2;
        weaknessType1 = (PokemonType)pokemon.weaknessType1;
        weaknessType2 = (PokemonType)pokemon.weaknessType2;
        weaknessType3 = (PokemonType)pokemon.weaknessType3;
        weaknessType4 = (PokemonType)pokemon.weaknessType4;
        availableMoves = new MoveList[3]
        {
            pokemon.availableMoves[0],
            pokemon.availableMoves[1],
            pokemon.availableMoves[2],
            //pokemon.availableMoves[3];
        };
    
    }
    public void MoveSet()
    {
        
    }
}

