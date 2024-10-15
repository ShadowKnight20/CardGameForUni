using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;


public class DisplayCardOpponent : MonoBehaviour
{
    public List<OpponentCard> displayCard = new List<OpponentCard>();
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

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject OpponentHand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCardsInDeck = OpponentPlayerDeck.deckSize;

        displayCard[0] = CardDatabaseDevil.cardList[displayId];

        id = displayCard[0].id;

    }

    // Update is called once per frame
    void Update()
    {
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
        OpponentHand = GameObject.Find("OpponentHand");

        if (this.transform.parent == OpponentHand.transform.parent)
        {
            cardBack = false;
        }
        
        staticCardBack = cardBack;

        if(this.tag == "Clone")
        {
            displayCard[0] = OpponentPlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            OpponentPlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }
    }
}
