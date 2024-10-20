using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinScript : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    public int coinNumber;

    public void coinFunction()
    {
        if(coinNumber > 0)
        {
            coinNumber--;
            TextBox.text = coinNumber.ToString();
        }

        
    }
}
