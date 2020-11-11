using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour
{
    

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Searchable"){
            if(Input.GetKeyDown("space")){
                other.GetComponent<SearchObject>().Search();
            }
        }
        if(other.tag == "Finish"){
            if (Input.GetKeyDown("space"))
            {
                //ゲームオブジェクト表示→非表示
                this.gameObject.SetActive(false);
            }
        }
        
    }
}
