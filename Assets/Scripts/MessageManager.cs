using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour
{
    public Text messageText;

    public void DisplayMessage(string message){
        messageText.text = message;
        messageText.gameObject.SetActive(true);
        StartCoroutine("Display");
    }

    IEnumerator Display(){
        float alpha = 0f;
        while(alpha < 1){
            messageText.color = new Color(255, 255, 255, alpha);
            alpha += 2 * Time.deltaTime;
            yield return null;
        }
        messageText.color = new Color(255, 255, 255, 1.0f);

        yield return new WaitForSeconds(2.0f);

        while(alpha > 0){
            messageText.color = new Color(255, 255, 255, alpha);
            alpha -= 2 * Time.deltaTime;
            yield return null;
        }
        messageText.color = new Color(255, 255, 255, 0f);
        messageText.gameObject.SetActive(false);
    }
}
