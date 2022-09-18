using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickEvidenceInScene : MonoBehaviour
{
    public GameObject clickableObject;
    public GameObject sceneObject;
    public GameObject canvasObject;

    public AudioSource evidenceAudio;

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickableObject.SetActive(false);
            sceneObject.SetActive(false);
            canvasObject.SetActive(true);
            evidenceAudio.Play();
        }

    }
    
}
