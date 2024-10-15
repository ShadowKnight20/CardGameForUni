using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToHandOpponent : MonoBehaviour
{
    public GameObject OpponentHand;
    public GameObject OpponentHandCard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpponentHand = GameObject.Find("OpponentHand");
        OpponentHandCard.transform.SetParent(OpponentHand.transform);
        OpponentHandCard.transform.localScale = Vector3.one;
        //Hand.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        //HandCard.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
