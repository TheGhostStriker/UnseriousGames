using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PublishPaperScript : MonoBehaviour
{

    private bool GoNext;
    public GameObject PressToGoEndScene;



    // Start is called before the first frame update
    void Start()
    {

        GoNext = false;
        PressToGoEndScene.SetActive(false);
        
    }

    private void Update()
    {
        if (GoNext)
        {
            PressToGoEndScene.SetActive(true);
        }

    }


    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GoNext = true;
            Debug.Log("I have been clicked");
        }

    }

    public void WritingWasDone()
    {
        PressToGoEndScene.SetActive(true);
    }

}
