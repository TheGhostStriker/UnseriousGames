using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitEvidence : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject sceneObject;
    public GameObject evidenceObject;
    

    public void whenButtonClicked()
    {
        canvasObject.SetActive(true);
        sceneObject.SetActive(false);
        evidenceObject.SetActive(false);
        

    }
}
