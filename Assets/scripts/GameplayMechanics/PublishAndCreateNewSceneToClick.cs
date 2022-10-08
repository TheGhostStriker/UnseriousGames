using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublishAndCreateNewSceneToClick : MonoBehaviour
{
    public GameObject newButton;

    public void OnButtonClicked()
    {
        newButton.SetActive(true);
    }
}
