using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> DisplayCards = new List<Card>();//have DisplayCard if something not working
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int health;
    public int armourClass;
    public int attack;
    public int damage;
    public string cardDescription;

    //public Text cardNameText;
    //public Text costText;
    public Text healthText;
    public Text armourClassText;
    public Text attackText;
    public Text damageText;
    public Text cardDescriptionText;


    // Start is called before the first frame update
    void Start()
    {
        DisplayCards[0] = CardDatabase.cardList[displayId]; //have DisplayCard if something not working
    }

    // Update is called once per frame
    void Update()
    {
        id = DisplayCards[0].id;
        cardName = DisplayCards[0].cardName;
        cost = DisplayCards[0].cost;
        health = DisplayCards[0].health;
        armourClass = DisplayCards[0].armourClass;
        attack = DisplayCards[0].attack;
        damage = DisplayCards[0].damage;
        cardDescription = DisplayCards[0].cardDescription;

        healthText.text = "" + health;
        armourClassText.text = "" + armourClass;
        attackText.text = ""+ attack;
        damageText.text = ""+ damage;
        cardDescriptionText.text = ""+cardDescription;


    }
}
