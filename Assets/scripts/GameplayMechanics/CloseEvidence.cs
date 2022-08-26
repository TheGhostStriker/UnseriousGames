using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseEvidence : MonoBehaviour
{
    public GameObject imageObject;
    public GameObject evidenceImage;
    public AudioSource pageTurn;
    public void OnMouseEnter()
    {
        if(Input.GetMouseButtonDown(0))
        {
            imageObject.SetActive(false);
            evidenceImage.SetActive(true);
            pageTurn.Play();
        }
    }
}
