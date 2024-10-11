using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        //Public Card has these properties Card(int Id,string CardName,int Cost, Sprite ThisCardsImage,int Attack, int Damage, int ArmourClass,int Health, bool Ranged, int RangedDamage,bool Spell, int SpellDamage,string CardDescription)
        //Use this code to add new cards in: 

        //Human Units array of 0-8

        //Melee
        cardList.Add(new Card(0, "Fighter", 1, Resources.Load<Sprite>(""), 2, 3, 13, 20, false,0, false, 0, ""));//Assets/CardImages/HumanCard/SwordmanCard.png
        cardList.Add(new Card(1, "Fighter", 2, Resources.Load<Sprite>(""), 4, 5, 15, 25, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/KnightCard.png
        cardList.Add(new Card(2, "Fighter", 3, Resources.Load<Sprite>(""), 5, 5, 17, 30, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/HeadKnightmanCrad.png

        //Ranged

        cardList.Add(new Card(3, "Ranger", 1, Resources.Load<Sprite>(""), 2, 0, 13, 20, true, 3, false, 0, ""));//Assets/CardImages/HumanCard/ArcherCard.png
        cardList.Add(new Card(4, "Weapon", 1, Resources.Load<Sprite>(""), 4, 0, 13, 20, true, 6, false, 0, ""));//Assets/CardImages/HumanCard/WeaponCard.png
        cardList.Add(new Card(4, "Mage", 1, Resources.Load<Sprite>(""), 5, 5, 13, 20, true, 5, false, 0, ""));//Assets/CardImages/HumanCard/MageCard.png

        //Human Spells

        cardList.Add(new Card(5, "Rite", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, false, 0, true, -2, "Get 2 points"));//Assets/CardImages/HumanCard/Spell1Card.png
        cardList.Add(new Card(6, "Dragon", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, false, 0, true, 0, "Destroy 1 opponent's card")); //need to add card removal from opponent //Assets/CardImages/HumanCard/Spell2Card.png

        //Human Equipment

        cardList.Add(new Card(7, "Sword and Shield", 1, Resources.Load<Sprite>(""), 3, 0, 2, 0, false, 0, true, 0, "")); //need properties for equipment (need to buff/attach card on a chosen unit) //Assets/CardImages/HumanCard/Equipment1Card.png
        cardList.Add(new Card(8, "Armour", 1, Resources.Load<Sprite>(""), 0, 0, 5, 0, false, 0, true, 0, ""));//Assets/CardImages/HumanCard/Equipment2Card.png

        //Deamon Units array of 9-16

        cardList.Add(new Card(9, "Devil", 1, Resources.Load<Sprite>(""), 3, 2, 13, 20, false, 0, false, 0, ""));
        cardList.Add(new Card(10, "Devil", 2, Resources.Load<Sprite>(""), 4, 3, 15, 25, false, 0, false, 0, ""));
        cardList.Add(new Card(11, "Devil", 3, Resources.Load<Sprite>(""), 5, 5, 17, 30, false, 0, false, 0, ""));

        //Ranged

        cardList.Add(new Card(12, "Lamia", 1, Resources.Load<Sprite>(""), 2, 0, 13, 20, true, 2, false, 0, ""));
        cardList.Add(new Card(13, "Behemoth", 2, Resources.Load<Sprite>(""), 4, 0, 14, 20, true, 3, false, 0, ""));
        cardList.Add(new Card(14, "Reaper", 3, Resources.Load<Sprite>(""), 5, 0, 16, 20, true, 6, false, 0, ""));

        //Deamon Spells

        cardList.Add(new Card(15, "Rite", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, false, 0, true, -2, "Get 2 points"));
        cardList.Add(new Card(16, "Reform", 1, Resources.Load<Sprite>(""), 0, 0, 0, 0, false, 0, true,0, ""));

        //Deamon Equipment

        cardList.Add(new Card(17, "Doom", 1, Resources.Load<Sprite>(""), 5, 0, 0, 0, false, 0, true, 0, ""));
        cardList.Add(new Card(18, "Devil's marks", 1, Resources.Load<Sprite>(""), 0, 0, 5, 0, true, 0, false, 0, ""));

    }
}
