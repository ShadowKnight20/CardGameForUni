using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackRandomNumber : MonoBehaviour
{
    
    
    public TextMeshProUGUI TextBox;
    public int TheNumber;

    public void RandomGenerate()
    {
        TheNumber = Random.Range(1, 21);
        TextBox.text = TheNumber.ToString();
    }
    
}
