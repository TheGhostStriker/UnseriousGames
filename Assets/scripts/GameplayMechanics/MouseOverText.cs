using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverText : MonoBehaviour
{
    public GameObject textBackground;
    public GameObject informationText;

    // Start is called before the first frame update
    void Start()
    {
        informationText.SetActive(false);
        textBackground.SetActive(false);
    }

    public void OnMouseEnter()
    {
        informationText.SetActive(true);
        textBackground.SetActive(true);
        Debug.Log("Mouse is over the object");
    }

    public void OnMouseExit()
    {
        informationText.SetActive(false);
        textBackground.SetActive(false);
        Debug.Log("Mouse is no longer over the object");
    }
}
