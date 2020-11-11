using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public static Dictionary<string, bool> items = new Dictionary<string, bool>(){
        {"chair", false},
        {"key_silver", false},
        {"key_gold", false},
    };
    
    public static void GetItem(string itemName){
        items[itemName] = true;
    }
    
    public static void UseItem(string itemName){
        items[itemName] = false;
    }
}
