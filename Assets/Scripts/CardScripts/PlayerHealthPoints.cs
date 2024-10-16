using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthPoints : MonoBehaviour
{
    public float maxHP;
    public static float staticHP;
    public float hp;
    public Image Health;
    public Text hpText;


    // Start is called before the first frame update
    void Start()
    {
        maxHP = 20;
        staticHP = 20;
    }

    // Update is called once per frame
    void Update()
    {
        hp = staticHP;
        Health.fillAmount = hp / maxHP;

        if(hp >= maxHP)
        {
            hp = maxHP;
        }

        hpText.text = hp+"HP";

    }
}
