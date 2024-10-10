using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        //Public Card has these properties Card(int Id,string CardName,int Cost, Sprite ThisCardsImage,int Attack, int Damage, int ArmourClass,int Health, bool Spell, int SpellDamage,string CardDescription)
        //Use this code to add new cards in: 

        //Human Units

        //Melee
        cardList.Add(new Card(0, "Fighter", 1, Resources.Load<Sprite>(""), 2, 3, 13, 20, false, 0, ""));
        cardList.Add(new Card(1, "Fighter", 2, Resources.Load<Sprite>(""), 4, 5, 15, 25, false, 0, ""));
        cardList.Add(new Card(2, "Fighter", 3, Resources.Load<Sprite>(""), 5, 5, 17, 30, false, 0, ""));

        //Ranged

        cardList.Add(new Card(3, "Ranger", 1, Resources.Load<Sprite>(""), 2, 3, 13, 20, false, 0, ""));
        cardList.Add(new Card(4, "Weapon", 1, Resources.Load<Sprite>(""), 4, 6, 13, 20, false, 0, ""));
        cardList.Add(new Card(4, "Mage", 1, Resources.Load<Sprite>(""), 5, 5, 13, 20, false, 0, ""));

        //Human Spells

        cardList.Add(new Card(5, "Rite", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, true, -2, "Get 2 points"));
        cardList.Add(new Card(6, "Dragon", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, true, 0, "Destroy 1 opponent's card")); //need to add card removal from opponent

        //Human Equipment

        cardList.Add(new Card(7, "Sword and Shield", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, false, 0, "")); //need properties for equipment (need to buff/attach card on a chosen unit)
        cardList.Add(new Card(8, "Weapon", 1, Resources.Load<Sprite>(""), 4, 6, 13, 20, false, 0, ""));

        //Deamon Units

        //cardList.Add(new Card(2, "Fighter", 3, Resources.Load<Sprite>(""), 5, 5, 17, 30, false, 0, ""));
        //cardList.Add(new Card(2, "Fighter", 3, Resources.Load<Sprite>(""), 5, 5, 17, 30, false, 0, ""));


        //Deamon Spells

        //Deamon Equipment

    }
}
