using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDisableImage : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject sceneObject;

    public void whenButtonClicked()
    {
        canvasObject.SetActive(true);
        sceneObject.SetActive(false);
    }
}
