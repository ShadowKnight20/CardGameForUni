using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject cardPrefab;
    public int[] deck;
    public GameObject[] deckCards;
    public GameObject[] fieldPosition;
    public GameObject[] fieldCards;
    public GameObject[] handCards;
    public GameObject discard;
    public GameObject[] discardCards;

    public int deckCount, handCount, discardCount;
    
    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < 6; i++)
        //{

        //}
        initiateCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void initiateCards()
    {
        int i = 0;
        foreach(int card in deck)
        {
            GameObject temp;
            temp = Instantiate(cardPrefab, transform.position, transform.rotation);
            deckCards[i] = temp;
            deckCards[i].GetComponent<CardScript>().player = this.gameObject;
            deckCards[i].GetComponent<CardScript>().repositoryPosition = card;
            deckCards[i].GetComponent<CardScript>().deckPosition = i;
            i++;
        }
    }
}
