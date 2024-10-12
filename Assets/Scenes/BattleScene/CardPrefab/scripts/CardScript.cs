using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardScript : MonoBehaviour
{
    public GameObject player;
    public int deckPosition, fieldPosition;
    public int repositoryPosition;
    public PlayerMain playerMain;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMain = FindObjectOfType<PlayerMain>();
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        //to test if it works in game
        //SetText();
    }

    void SetText()
    {
        GameObject TMP;

        TMP = this.gameObject.transform.GetChild(0).gameObject;
        TMP.GetComponent<TextMeshPro>().text = playerMain.GetComponent<PlayerMain>().cardTypes[repositoryPosition];

        TMP = this.gameObject.transform.GetChild(1).gameObject;
        TMP.GetComponent<TextMeshPro>().text = playerMain.GetComponent<PlayerMain>().cardNames[repositoryPosition];

        TMP = this.gameObject.transform.GetChild(2).gameObject;
        TMP.GetComponent<TextMeshPro>().text = playerMain.GetComponent<PlayerMain>().healthPoints[repositoryPosition].ToString();

        TMP = this.gameObject.transform.GetChild(3).gameObject;
        TMP.GetComponent<TextMeshPro>().text = playerMain.GetComponent<PlayerMain>().armorClass[repositoryPosition].ToString();

        TMP = this.gameObject.transform.GetChild(4).gameObject;
        TMP.GetComponent<TextMeshPro>().text = playerMain.GetComponent<PlayerMain>().attackModifiers[repositoryPosition].ToString();

        TMP = this.gameObject.transform.GetChild(5).gameObject;
        TMP.GetComponent<TextMeshPro>().text = playerMain.GetComponent<PlayerMain>().damageModifiers[repositoryPosition].ToString();
    }


    //make card draggable
    private Vector3 _dragOffset;
    private Camera _cam;


    void Awake()
    {
        _cam = Camera.main;
    }

    //stop mouse click snapping to pivot point
    void OnMouseDown()
    {
        _dragOffset = transform.position - GetMousePos();
    }

    //drag object on click
    void OnMouseDrag()
    {
        transform.position = GetMousePos() + _dragOffset;
    }

    void OnMouseUp()
    {
        for(int i = 0; i < 24; i++)
        {
            if (player.GetComponent<Player>().fieldPosition[i].GetComponent<FieldPosition>().isMouseOver)
            {
                deckPosition = -1;
                fieldPosition = i;
            }
        }
    }

    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }


}
