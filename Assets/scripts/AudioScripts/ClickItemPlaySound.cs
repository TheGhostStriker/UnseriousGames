using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItemPlaySound : MonoBehaviour
{
    public AudioSource itemClickAudio;


    public void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
    }
    public void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            itemClickAudio.Play();
            Debug.Log("Item Has Been Clicked, Audio should be playing");

        }

        if(Input.GetMouseButtonDown(1))
        {
            itemClickAudio.Stop();
            Debug.Log("Audio stopped");
        }
    }
    
}
