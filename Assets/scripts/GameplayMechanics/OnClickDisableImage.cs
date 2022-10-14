using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDisableImage : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject sceneObject;
    public GameObject sceneButtons;

    public void whenButtonClicked()
    {
        sceneButtons.SetActive(false);
        canvasObject.SetActive(true);
        sceneObject.SetActive(false);
    }
}
