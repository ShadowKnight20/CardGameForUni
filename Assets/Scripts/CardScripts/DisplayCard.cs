using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;


public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int health;
    public int armourClass;
    public int attack;
    public int damage;
    public string cardDescription;
    public Sprite thisCardImage;

    //public Text cardNameText;
    //public Text costText;
    public Text healthText;
    public Text armourClassText;
    public Text attackText;
    public Text damageText;
    public Text cardDescriptionText;
    public Image cardArtImage;


    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];

        id = displayCard[0].id;

        Debug.Log(displayCard.Count);

        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        health = displayCard[0].health;
        armourClass = displayCard[0].armourClass;
        attack = displayCard[0].attack;
        damage = displayCard[0].damage;
        cardDescription = displayCard[0].cardDescription;
        thisCardImage = displayCard[0].thisCardsImage;

        healthText.text = "" + health;
        armourClassText.text = "" + armourClass;
        attackText.text = "" + attack;
        damageText.text = "" + damage;
        cardDescriptionText.text = "" + cardDescription;
        cardArtImage.sprite = thisCardImage;

        Debug.Log(displayCard.Count);


    }

    // Update is called once per frame
    void Update()
    {


    }
    void Awake()
    {
        //Public Card has these properties Card(int Id,string CardName,int Cost, Sprite ThisCardsImage,int Attack, int Damage, int ArmourClass,int Health, bool Ranged, int RangedDamage,bool Spell, int SpellDamage,string CardDescription)
        //Use this code to add new cards in: 

        //Human Units array of 0-9

        //Melee
        //displayCard.Add(new Card(0, "Swordman", 1, Resources.Load<Sprite>("SwordmanCard"), 2, 3, 13, 20, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/SwordmanCard.png
        //displayCard.Add(new Card(1, "Knight", 2, Resources.Load<Sprite>("KnightCard"), 4, 5, 15, 25, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/KnightCard.png
        //displayCard.Add(new Card(2, "Mounted Knight", 3, Resources.Load<Sprite>("HeadKnightmanCrad"), 5, 5, 17, 30, false, 0, false, 0, ""));//Assets/CardImages/HumanCard/HeadKnightmanCrad.png
    }
}
