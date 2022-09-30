using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMouseOnMouseOver : MonoBehaviour
{

    [SerializeField] Texture2D MouseOverTexture;
    public bool MouseOver = false;
    // [SerializeField] Texture2D defaultTexture;
    // Start is called before the first frame update



    
    
    public void Update()
    {
        

        if (MouseOver == true)
        {
            Cursor.SetCursor(MouseOverTexture, Vector3.zero, CursorMode.ForceSoftware);
        }
     
        else if (MouseOver == false)
            
            {
            
            Cursor.SetCursor(null, Vector3.zero, CursorMode.ForceSoftware);
            }
    }

    public void OnMouseOver()
    {
        MouseOver = true;
        Debug.Log("Im a spaz");
    }

    public void OnMouseExit()
    {
        MouseOver = false;
    }

    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MouseOver = false;
            Cursor.SetCursor(null, Vector3.zero, CursorMode.ForceSoftware);
            Debug.Log("TURN OFF BITCH");
        }
    }




    //public void OnMouseButtonDown()
    //{
    //    Cursor.SetCursor(null, Vector3.zero, CursorMode.ForceSoftware);
    //}
}
