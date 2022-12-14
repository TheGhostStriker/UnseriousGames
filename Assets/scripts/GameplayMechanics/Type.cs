using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type : MonoBehaviour
{//Put this script on a button.
    
    public Text textBox; //the text object.
    public GameObject typeSound; //The audio source game object
    [TextArea(3, 10)]
    public string info; //In this field enter the things you want to be typed on the typewriter. Leave a space at the end.
    public float delay; //The time delay between characters being typed. 0.02 - 0.05 works well.
    private AudioSource audioSauce;

    void Awake()
    {
        audioSauce = typeSound.GetComponent<AudioSource>();
    }

    //Make the on click event this.
    public void EnterLine()
    {
        StopAllCoroutines();
        StartCoroutine(TypeInfo());
    }

    //Coroutine types a charachter, then waits until delay has passed.
    IEnumerator TypeInfo()
    {
        foreach (char letter in info.ToCharArray()) {
            if (audioSauce != null)
            {
                audioSauce.Play();
            }
            textBox.text += letter;
            yield return new WaitForSeconds(delay);
        }
    }
}