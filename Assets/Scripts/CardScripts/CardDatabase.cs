using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        //Debug.Log(cardList.Count);
        //Public Card has these properties Card(int Id,string CardName,int Cost, Sprite ThisCardsImage,int Attack, int Damage, int ArmourClass,int Health, bool Ranged, int RangedDamage,bool Spell, int SpellDamage,string CardDescription)
        //Use this code to add new cards in: 

        //Human Units array of 1-10

        //cardList.Add(new Card(0, "None", 1, Resources.Load<Sprite>(""), 99, 99, 99, 99, false, 0, false, 0, ""));//Null card dosent exists

        //Melee
        cardList.Add(new Card(0, "Swordman", 1, Resources.Load<Sprite>("SwordmanCard"), 2, 3, 13, 20, false,0, false, 0, ""));
        cardList.Add(new Card(1, "Knight", 2, Resources.Load<Sprite>("KnightCard"), 4, 5, 15, 25, false, 0, false, 0, ""));
        cardList.Add(new Card(2, "Mounted Knight", 3, Resources.Load<Sprite>("HeadKnightmanCrad"), 5, 5, 17, 30, false, 0, false, 0, ""));

        //Ranged

        cardList.Add(new Card(3, "Archer", 1, Resources.Load<Sprite>("ArcherCard"), 2, 0, 13, 20, true, 3, false, 0, ""));
        cardList.Add(new Card(4, "Catapult", 1, Resources.Load<Sprite>("WeaponCard"), 4, 0, 13, 20, true, 6, false, 0, ""));
        cardList.Add(new Card(5, "Sorcerer", 1, Resources.Load<Sprite>("MageCard"), 5, 5, 13, 20, true, 5, false, 0, ""));
        ////Human Spells

        //cardList.Add(new Card(6, "Sign", 1, Resources.Load<Sprite>("Spell1Card"), 0, 0, 0, 0, false, 0, true, -2, "Get 2 points"));
        //cardList.Add(new Card(7, "Dragon", 1, Resources.Load<Sprite>("Spell2Card"), 0, 0, 0, 0, false, 0, true, 0, "Destroy 1 opponent's card")); //need to add card removal from opponent 

        ////Human Equipment

        //cardList.Add(new Card(8, "Sword and Shield", 1, Resources.Load<Sprite>("Equipment1Card"), 3, 0, 2, 0, false, 0, true, 0, "")); //need properties for equipment (need to buff/attach card on a chosen unit) //Assets/CardImages/HumanCard/Equipment1Card.png
        //cardList.Add(new Card(9, "Armour", 1, Resources.Load<Sprite>("Equipment2Card"), 0, 0, 5, 0, false, 0, true, 0, ""));

        ////Deamon Units array of 10-19

        //cardList.Add(new Card(11, "Balthazer", 1, Resources.Load<Sprite>("BalthazerCard"), 3, 2, 13, 20, false, 0, false, 0, ""));
        //cardList.Add(new Card(12, "Abaddon", 2, Resources.Load<Sprite>("AbaddonCard"), 4, 3, 15, 25, false, 0, false, 0, ""));
        //cardList.Add(new Card(13, "Grunt", 3, Resources.Load<Sprite>("GruntCard"), 5, 5, 17, 30, false, 0, false, 0, ""));

        //////Ranged

        //cardList.Add(new Card(14, "Lamia", 1, Resources.Load<Sprite>("LamiaCard"), 2, 0, 13, 20, true, 2, false, 0, ""));
        //cardList.Add(new Card(15, "Behemoth", 2, Resources.Load<Sprite>("BehemothCard"), 4, 0, 14, 20, true, 3, false, 0, ""));
        //cardList.Add(new Card(16, "Reaper", 3, Resources.Load<Sprite>("ReaperCard"), 5, 0, 16, 20, true, 6, false, 0, ""));

        //////Deamon Spells

        //cardList.Add(new Card(17, "Rite", 1, Resources.Load<Sprite>("DevilSpell1Card"), 0, 0, 0, 0, false, 0, true, -2, "Get 2 points"));
        //cardList.Add(new Card(18, "Reform Oneself", 1, Resources.Load<Sprite>("DevilSpell2Card"), 0, 0, 0, 0, false, 0, true,0, ""));

        //////Deamon Equipment

        //cardList.Add(new Card(19, "Trident Of Doom", 1, Resources.Load<Sprite>("DevilEquipment1Card"), 5, 0, 0, 0, false, 0, true, 0, ""));
        //cardList.Add(new Card(20, "Devil's marks", 1, Resources.Load<Sprite>("DevilEquipment2Card"), 0, 0, 5, 0, true, 0, false, 0, ""));

    }
}
