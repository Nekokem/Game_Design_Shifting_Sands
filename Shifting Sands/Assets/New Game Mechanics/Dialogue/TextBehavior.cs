using UnityEngine; 
using UnityEngine.Events; 
using UnityEngine.UI; 
 
[RequireComponent(typeof(Text))] 
public class TextBehavior : MonoBehaviour 
{ 
     
    private Text textObj; 
    public UnityEvent awakeEvent; 
     
    void Awake() 
    { 
        textObj = GetComponent<Text>(); 
    } 
     
    public void UpdateText(StringListData stringListDataObj) 
    { 
        textObj.text = stringListDataObj.ReturnCurrentLine(); 
    } 
    /*Cant use this in event system!*/ 
 
    public void UpdateText(IntData intDataObj) 
    { 
        textObj.text = intDataObj.value.ToString(); 
    } 
  
}