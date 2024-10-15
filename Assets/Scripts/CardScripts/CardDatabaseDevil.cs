using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class CardDatabaseDevil : MonoBehaviour
{
    public static List<OpponentCard> cardList = new List<OpponentCard>();

    void Awake()
    {
 
        ////Deamon Units array

        cardList.Add(new OpponentCard(1, "Balthazer", 1, Resources.Load<Sprite>("BalthazerCard"), 3, 2, 13, 20, false, 0, false, 0, ""));
        cardList.Add(new OpponentCard(2, "Abaddon", 2, Resources.Load<Sprite>("AbaddonCard"), 4, 3, 15, 25, false, 0, false, 0, ""));
        cardList.Add(new OpponentCard(3, "Grunt", 3, Resources.Load<Sprite>("GruntCard"), 5, 5, 17, 30, false, 0, false, 0, ""));

        ////Ranged

        cardList.Add(new OpponentCard(4, "Lamia", 1, Resources.Load<Sprite>("LamiaCard"), 2, 0, 13, 20, true, 2, false, 0, ""));
        cardList.Add(new OpponentCard(5, "Behemoth", 2, Resources.Load<Sprite>("BehemothCard"), 4, 0, 14, 20, true, 3, false, 0, ""));
        cardList.Add(new OpponentCard(6, "Reaper", 3, Resources.Load<Sprite>("ReaperCard"), 5, 0, 16, 20, true, 6, false, 0, ""));

        ////Deamon Spells

        cardList.Add(new OpponentCard(7, "Rite", 1, Resources.Load<Sprite>("DevilSpell1Card"), 0, 0, 0, 0, false, 0, true, -2, "Get 2 points"));
        cardList.Add(new OpponentCard(8, "Reform Oneself", 1, Resources.Load<Sprite>("DevilSpell2Card"), 0, 0, 0, 0, false, 0, true,0, ""));

        ////Deamon Equipment

        cardList.Add(new OpponentCard(9, "Trident Of Doom", 1, Resources.Load<Sprite>("DevilEquipment1Card"), 5, 0, 0, 0, false, 0, true, 0, ""));
        cardList.Add(new OpponentCard(10, "Devil's marks", 1, Resources.Load<Sprite>("DevilEquipment2Card"), 0, 0, 5, 0, true, 0, false, 0, ""));


       //Debug.Log(cardList.Count);
        //Public Card has these properties Card(int Id,string CardName,int Cost, Sprite ThisCardsImage,int Attack, int Damage, int ArmourClass,int Health, bool Ranged, int RangedDamage,bool Spell, int SpellDamage,string CardDescription)
        //Use this code to add new cards in: 

        //Human Units array of 1-10

        //cardList.Add(new Card(0, "None", 1, Resources.Load<Sprite>(""), 99, 99, 99, 99, false, 0, false, 0, ""));//Null card dosent exists

        ////Melee
        //cardList.Add(new Card(1, "Swordman", 1, Resources.Load<Sprite>("SwordmanCard"), 2, 3, 13, 20, false,0, false, 0, ""));//Assets/CardImages/HumanCard/SwordmanCard.png
        //cardList.Add(new Card(2, "Knight", 2, Resources.Load<Sprite>("KnightCard"), 4, 5, 15, 25, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/KnightCard.png
        //cardList.Add(new Card(3, "Mounted Knight", 3, Resources.Load<Sprite>("HeadKnightmanCrad"), 5, 5, 17, 30, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/HeadKnightmanCrad.png

        ////Ranged

        //cardList.Add(new Card(4, "Archer", 1, Resources.Load<Sprite>("ArcherCard"), 2, 0, 13, 20, true, 3, false, 0, ""));//Assets/CardImages/HumanCard/ArcherCard.png
        //cardList.Add(new Card(5, "Catapult", 1, Resources.Load<Sprite>("WeaponCard"), 4, 0, 13, 20, true, 6, false, 0, ""));//Assets/CardImages/HumanCard/WeaponCard.png
        //cardList.Add(new Card(6, "Sorcerer", 1, Resources.Load<Sprite>("MageCard"), 5, 5, 13, 20, true, 5, false, 0, ""));//Assets/CardImages/HumanCard/MageCard.png

        //////Human Spells

        //cardList.Add(new Card(7, "Sign", 1, Resources.Load<Sprite>("Spell1Card"), 0, 0, 0, 0, false, 0, true, -2, "Get 2 points"));//Assets/CardImages/HumanCard/Spell1Card.png
        //cardList.Add(new Card(8, "Dragon", 1, Resources.Load<Sprite>("Spell2Card"), 0, 0, 0, 0, false, 0, true, 0, "Destroy 1 opponent's card")); //need to add card removal from opponent //Assets/CardImages/HumanCard/Spell2Card.png

        //////Human Equipment

        //cardList.Add(new Card(9, "Sword and Shield", 1, Resources.Load<Sprite>("Equipment1Card"), 3, 0, 2, 0, false, 0, true, 0, "")); //need properties for equipment (need to buff/attach card on a chosen unit) //Assets/CardImages/HumanCard/Equipment1Card.png
        //cardList.Add(new Card(10, "Armour", 1, Resources.Load<Sprite>("Equipment2Card"), 0, 0, 5, 0, false, 0, true, 0, ""));//Assets/CardImages/HumanCard/Equipment2Card.png
    }
}
