using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class MouseDownEvents : MonoBehaviour
{
    public UnityEvent mouseDownClick;
    public UnityEvent mouseUpEvent;

    public void OnMouseDown()
    {
        mouseDownClick.Invoke();
    }

    public void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }
}
