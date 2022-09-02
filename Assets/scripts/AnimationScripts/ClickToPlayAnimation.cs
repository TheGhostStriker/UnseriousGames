using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlayAnimation : MonoBehaviour
{
    public Animator testAnimation;


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
            
            testAnimation.SetBool("playAnim", true);
        }

        if(Input.GetMouseButtonDown(1))
        {
            
            testAnimation.SetBool("playAnim", false);
        }
    }

    
}
