using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour
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
    //
    //private Vector3 _dragOffset;
    //private Camera _cam;

    //use speed to add a bit of lag to the dragging for visual interest
    //[SerializeField] private float _speed = 5;

    //void Awake()
    //{
    //    _cam = Camera.main;
    //}

    ////stop mouse click snapping to pivot point
    //void OnMouseDown()
    //{
    //    _dragOffset = transform.position - GetMousePos();
    //}

    ////drag object on click
    //void OnMouseDrag()
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * Time.deltaTime);
    //}

    //Vector3 GetMousePos()
    //{
    //    var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
    //    mousePos.z = 0;
    //    return mousePos;
    //}
}
