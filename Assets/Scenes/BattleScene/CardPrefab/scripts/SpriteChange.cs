using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpriteChange : MonoBehaviour
{
    public GameObject card;
    public Sprite[] sprites;
    PlayerMain playerMain;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMain = FindObjectOfType<PlayerMain>();
        SetType();
    }

    // Update is called once per frame
    void Update()
    {
        //delete after testing
        //SetType();
    }

    void SetType()
    {
        switch (playerMain.GetComponent<PlayerMain>().cardNames[card.GetComponent<CardScript>().repositoryPosition])
        {
            case "Swordsman":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                break;
            case "Knight":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
                break;
            case "Head Knight":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
                break;
            case "Archer":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
                break;
            case "Sorcerer":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[4];
                break;
            case "Catapult":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[5];
                break;
            case "Abaddon":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[6];
                break;
            case "Balthazar":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[7];
                break;
            case "Behemoth":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[8];
                break;
            case "Grunt":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[9];
                break;
            case "Lamia":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[10];
                break;
            case "Reaper":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[11];
                break;

        }
    }
}
