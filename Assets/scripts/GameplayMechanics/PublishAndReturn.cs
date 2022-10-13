using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PublishAndReturn : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject sceneButton;
    public GameObject typeScene;
    public GameObject highlightButton;
    public AudioSource typewriterAudio;
    

    public void WhenButtonClicked()
    {
        canvasObject.SetActive(true);
        typeScene.SetActive(false);
        Destroy(highlightButton);
        sceneButton.GetComponent<Button>().enabled = false;
        typewriterAudio.Stop();
    }
}
