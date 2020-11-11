using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject camera;
    public GameObject button;
    public bool hasCube;
    //ボタンで操作
    public void CubeClick(){
        camera.transform.position += new Vector3(0,0,5);
        button.SetActive(false);
        //SetActiveでつけたり消したり
    }
}
