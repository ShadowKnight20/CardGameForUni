using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour //Human Cards Only at the moment
{
    
    public List<Card> container = new List<Card>();
    public int x;
    public static int deckSize;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();


    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject cardInDeck5;

    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 29; //temporary number

        for (int i = 0; i < 29; i++) //30 cards in a deck minus 1 as you start with 1 in hand (29)
        {
            x = Random.Range(i, 9);
            deck[i]=CardDatabase.cardList[x];
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
    }

    IEnumerator StartGame()
    {
        for (int i = 0;i <= 11; i++)
        {
            yield return new WaitForSeconds(1);

            //audioSource.PlayOneShot()

            Instantiate(CardToHand, transform.position, transform.rotation);
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
}
