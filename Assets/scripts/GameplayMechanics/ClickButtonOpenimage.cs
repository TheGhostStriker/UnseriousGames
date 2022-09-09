using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButtonOpenimage : MonoBehaviour
{
    
    public GameObject firstScene;
    public GameObject canvasObject;

    public void Start()
    {
        
    }
    public void whenButtonClicked()
    {
        canvasObject.SetActive(false);
        firstScene.SetActive(true);
    }
}

