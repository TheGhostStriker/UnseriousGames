using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMouseOnMouseOver : MonoBehaviour
{

    [SerializeField] Texture2D MouseOverTexture;
   // [SerializeField] Texture2D defaultTexture;
    // Start is called before the first frame update


    public void OnMouseOver()
    {
        Cursor.SetCursor(MouseOverTexture, Vector3.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector3.zero, CursorMode.ForceSoftware);
    }
}
