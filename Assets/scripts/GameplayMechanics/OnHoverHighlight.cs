using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverHighlight : MonoBehaviour
{
    public GameObject highlightButton;
    // Start is called before the first frame update
   public void OnMouseOver()
    {
        highlightButton.SetActive(true);
    }

    public void OnMouseExit()
    {
        highlightButton.SetActive(false);   
    }
}
