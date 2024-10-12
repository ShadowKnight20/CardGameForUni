using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldPosition : MonoBehaviour
{
    public bool isMouseOver;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }
}
