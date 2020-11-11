using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchObject : MonoBehaviour
{
    public string[] actions;
    public GameObject[] objects;
    public string[] ItemNames;
    public string[] messageTexts;
    public Vector3[] vectors;
   
    public void Search(){
        for(int i=0; i<actions.Length; i++){
            string[] action = actions[i].Split(':');
            switch (action[0])
            {
                case "finishAction":
                    return;
                case "getItem":
                    PlayerItems.GetItem(ItemNames[ int.Parse(action[1]) ]);
                    break;
                case "useItem":
                    PlayerItems.UseItem(ItemNames[ int.Parse(action[1]) ]);
                    break;
                case "destroyObject":
                    objects[ int.Parse(action[1]) ].SetActive(false);
                    break;
                case "createObject":
                    objects[ int.Parse(action[1]) ].SetActive(true);
                    break;
                case "moveObject":
                    objects[ int.Parse(action[1]) ].transform.position += vectors[ int.Parse(action[2]) ];
                    break;
                case "checkItem":
                    Debug.Log("a");
                    if(PlayerItems.items[ItemNames[ int.Parse(action[1]) ]]){
                        i = int.Parse(action[2]) - 1;
                    }else {
                        i = int.Parse(action[3]) - 1;
                    }
                    break;
                case "displayimage":
                    objects[ int.Parse(action[1]) ].SetActive(true);
                    break;
                case "deleteimage":
                    objects[ int.Parse(action[1]) ].SetActive(false);
                    break;
                case "displayMessage":
                    Debug.Log("aa");
                    GameObject.Find("MessageManager").GetComponent<MessageManager>().DisplayMessage(messageTexts[ int.Parse(action[1]) ]);
                    break;
                default:
                    break;
            }
        }
        
    }

}