using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItemPlaySound : MonoBehaviour
{
    public AudioSource itemClickAudio;

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            itemClickAudio.Play();
            Debug.Log("Item Has Been Clicked, Audio should be playing");

        }
    }
}
