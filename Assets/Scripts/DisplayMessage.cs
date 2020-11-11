using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    public GameObject score_object = null; 
    
    public static Dictionary<string, bool> messages = new Dictionary<string, bool>(){
        
        {"脱出", false},
    };
}
