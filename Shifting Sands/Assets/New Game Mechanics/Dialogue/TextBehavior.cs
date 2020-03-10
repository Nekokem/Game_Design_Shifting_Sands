using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{

    private Text textObj;

    private void Awake()
    {
        textObj = GetComponent<Text>();
    }

    void Update()
    {
        textObj.text = StringListData.ReturnCurrentLine();
    }
}
