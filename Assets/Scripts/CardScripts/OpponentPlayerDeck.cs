using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentPlayerDeck : MonoBehaviour //Devil Cards
{
    
    public List<OpponentCard> container = new List<OpponentCard>();
    public int y;
    public static int deckSize;
    public List<OpponentCard> deck = new List<OpponentCard>();
    public static List<OpponentCard> staticDeck = new List<OpponentCard>();


    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject cardInDeck5;

    public GameObject CardToHandOpponent;
    public GameObject[] Clones;
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        y = 0;
        deckSize = 29; //temporary number

        for (int i = 0; i < 29; i++) //30 cards in a deck minus 1 as you start with 1 in hand (29)
        {
            y = Random.Range(1,10);
            Debug.Log(y);
            deck[i]=CardDatabaseDevil.cardList[y];
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;


        //Deck visual on how many cards are left in a player deck
        if (deckSize < 25)
        {
            cardInDeck1.SetActive(false);
        }
        if (deckSize < 20)
        {
            cardInDeck2.SetActive(false);
        }
        if (deckSize < 15)
        {
            cardInDeck3.SetActive(false);
        }
        if (deckSize < 10)
        {
            cardInDeck4.SetActive(false);
        }
        if (deckSize < 5)
        {
            cardInDeck5.SetActive(false);
        }
        if (TurnSystem.startTurn == true)
        {
            StartCoroutine(Draw(1));
            //TurnSystem.startTurn = false;
        }

    }

    IEnumerator StartGame()
    {
        for (int i = 0;i <= 3; i++) //cards at the start of game (player starts with 4) +1 later when its start of their turn
        {
            yield return new WaitForSeconds(1);

            //audioSource.PlayOneShot()

            Instantiate(CardToHandOpponent, transform.position, transform.rotation);
        }
    }

    public void Shuffle() //Shuffles players cards
    {
        for (int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }
    IEnumerator Draw(int x) 
    { 
        for(int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardToHandOpponent, transform.position, transform.rotation);
        }
    }
}
