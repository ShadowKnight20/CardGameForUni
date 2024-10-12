using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Drag : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //code for making an object draggable


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

    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }


}
