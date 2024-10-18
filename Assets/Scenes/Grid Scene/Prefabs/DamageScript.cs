using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour
{

    public GameObject TextBox;
    public int TheNumber;

    public void RandomGenerate()
    {
        TheNumber = Random.Range(1, 6);
        TextBox.GetComponent<Text>().text = "" + TheNumber;

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
