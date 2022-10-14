using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButtonOpenimage : MonoBehaviour
{
    
    public GameObject firstScene;
    public GameObject canvasObject;
    public GameObject firstSceneItems;
    public GameObject sceneButtons;
    

    public void Start()
    {
        
    }
    public void whenButtonClicked()
    {
        sceneButtons.SetActive(false);
        firstSceneItems.SetActive(true);
        canvasObject.SetActive(false);
        firstScene.SetActive(true);
    }
}

