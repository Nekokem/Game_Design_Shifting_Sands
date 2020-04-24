using System;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class ImageCtrlr : MonoBehaviour
{
    public Image imageComponent;
    public FloatData ImgFillFloat;
    private void Start ()
    {
        imageComponent = GetComponent<Image>();
    }

    private void Update()
    {
        imageComponent.fillAmount = ImgFillFloat.value;
    }

}
