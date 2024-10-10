using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        //Public Card has these properties (int Id,string CardName,int Cost, int Attack, int Damage, int ArmourClass,int Health, string CardDescription)
        //Use this code to add new cards in: cardList.Add(new Card(0, "null", 0, 0, 0, 0, 0, "null"));

        cardList.Add(new Card(0, "null", 0, 0, 0, 0, 0, "null"));
        cardList.Add(new Card(1, "Ranger", 1, 10, 2, 15, 20, "null"));
        cardList.Add(new Card(2, "Knight", 2, 12, 3, 17, 25, "null"));
        cardList.Add(new Card(3, "Someguy", 3, 0, 0, 0, 0, "null"));
        cardList.Add(new Card(4, "Otherguy", 4, 0, 0, 0, 0, "null"));
        cardList.Add(new Card(5, "guyguy", 5, 0, 0, 0, 0, "null"));
    }
}
