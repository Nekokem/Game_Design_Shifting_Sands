using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class MouseEvents : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent mouseDownClick;

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDownClick.Invoke();
    }
}
