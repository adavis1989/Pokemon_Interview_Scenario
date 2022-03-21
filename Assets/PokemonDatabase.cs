using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonDatabase : MonoBehaviour
{
    public Dictionary<string, Pokemon> pokemonList = new Dictionary<string, Pokemon>();
    public MoveListDataBase moveListDatabase;
    void Start()
    {

        if (moveListDatabase != null)
        {
            //Pokemon Database Params       ("name", id, currentLevel, maxHP, attack, defense, specialAttack, specialDefense, speed, pokemonType1, pokemonType2)
            Pokemon squirtle = new Pokemon("Squirtle", 7, Random.Range(5, 8), Random.Range(44, 70), Random.Range(48, 70), Random.Range(65, 85), Random.Range(50, 70), Random.Range(64, 84), Random.Range(43, 63), Pokemon.PokemonType.Water, Pokemon.PokemonType.None)
            {
                weaknessType1 = Pokemon.PokemonType.Electric,
                weaknessType2 = Pokemon.PokemonType.Grass,
                weaknessType3 = Pokemon.PokemonType.None,
                weaknessType4 = Pokemon.PokemonType.None,
                availableMoves = new MoveList[3]
                {
                    moveListDatabase.moveList["Tackle"],
                    moveListDatabase.moveList["Tail Whip"],
                    moveListDatabase.moveList["Water Gun"]
                }
            };
            //Pokemon Database Params       ("name", id, currentLevel, maxHP, attack, defense, specialAttack, specialDefense, speed, pokemonType1, pokemonType2)
            Pokemon charmander = new Pokemon("Charmander", 4, Random.Range(5, 8), Random.Range(39, 59), Random.Range(52, 72), Random.Range(43, 63), Random.Range(60, 80), Random.Range(50, 70), Random.Range(65, 85), Pokemon.PokemonType.Fire, Pokemon.PokemonType.None)
            {
                weaknessType1 = Pokemon.PokemonType.Water,
                weaknessType2 = Pokemon.PokemonType.Ground,
                weaknessType3 = Pokemon.PokemonType.Rock,
                weaknessType4 = Pokemon.PokemonType.None,
                availableMoves = new MoveList[3]
                {
                    moveListDatabase.moveList["Scratch"],
                    moveListDatabase.moveList["Growl"],
                    moveListDatabase.moveList["Ember"]
                }
            };
            //Pokemon Database Params       ("name", id, currentLevel, maxHP, attack, defense, specialAttack, specialDefense, speed, pokemonType1, pokemonType2)
            Pokemon pidgey = new Pokemon("Pidgey", 16, Random.Range(5, 8), Random.Range(40, 60), Random.Range(45, 65), Random.Range(40, 60), Random.Range(35, 55), Random.Range(35, 55), Random.Range(56, 76), Pokemon.PokemonType.Normal, Pokemon.PokemonType.Flying)
            {
                weaknessType1 = Pokemon.PokemonType.Electric,
                weaknessType2 = Pokemon.PokemonType.Ice,
                weaknessType3 = Pokemon.PokemonType.Rock,
                weaknessType4 = Pokemon.PokemonType.None,
                availableMoves = new MoveList[3]
                {
                    moveListDatabase.moveList["Tackle"],
                    moveListDatabase.moveList["Sand Attack"],
                    moveListDatabase.moveList["Growl"]
                }
            };


            pokemonList.Add("Squirtle", squirtle);
            pokemonList.Add("Charmander", charmander);
            pokemonList.Add("Pidgey", pidgey);

        }
        else
        {
            Debug.Log("MoveListDatabase is NULL!!");
        }
    }
}
