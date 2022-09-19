using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickToAddText : MonoBehaviour
{

    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    
    

    public GameObject textButton;
    public GameObject otherTextButton;
    public GameObject thirdTextButton;

    public EvidenceCounter boolSwitch;

    public AudioSource typeWriterAudio;
    

    // Start is called before the first frame update
    void Start()
    {

        typeWriterAudio.time = 0.0f;
    }

    public void Update()
    {
        if(typeWriterAudio.time > 40.0f)
        {
            typeWriterAudio.Stop();
        }
    }

    public void OnButtonPressed()
    {
        StartCoroutine(ShowText());

        boolSwitch.GetComponent<EvidenceCounter>();
        boolSwitch.tellTruthButton = false;
        textButton.SetActive(false);
        otherTextButton.SetActive(false);
        thirdTextButton.SetActive(false);

        
        
        typeWriterAudio.Play();

       
        
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            

            yield return new WaitForSeconds(delay);
            
        }
        
        
        
    }

    

    
}
