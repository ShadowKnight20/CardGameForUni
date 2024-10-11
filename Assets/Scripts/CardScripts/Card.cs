using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    //card basics

    public int id;
    public string cardName;
    public int cost;
    public string cardDescription;

    public Sprite thisCardsImage;

    //Units stats

    public int attack;
    public int damage;
    public int armourClass;
    public int health;

    //ranged

    public bool ranged;
    public int rangedDamage;

    //Spell/Equipment stats

    public bool spell;
    public int spellDamage;

    //Effects

    //Remove card from the opponents hand
    
    public Card()
    {

    }
    public Card(int Id,string CardName,int Cost, Sprite ThisCardsImage,
        int Attack, int Damage, int ArmourClass,int Health, 
        bool Ranged, int RangedDamage, 
        bool Spell, int SpellDamage,
        string CardDescription)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        thisCardsImage = ThisCardsImage;

        attack = Attack;
        damage = Damage;
        armourClass = ArmourClass;
        health = Health;

        ranged = Ranged;
        rangedDamage = RangedDamage;

        spell = Spell;
        spellDamage = SpellDamage;

        cardDescription = CardDescription;
    }


}
