using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvidenceCounter : MonoBehaviour
{

    public GameObject TruthButton;

    public int totalEvidenceCollected = 0;
    public int EvidenceAmountInScene;

    public bool tellTruthButton = false;

    //public Button truthButton;

    private void Start()
    {
        TruthButton.SetActive(false);
    }

    private void Update()
    {
        if(tellTruthButton == false)
        {
            if(totalEvidenceCollected >= EvidenceAmountInScene)
            {
                tellTruthButton = true;
            }
        }

        if (tellTruthButton)
        {
            TruthButton.SetActive(true);
        }

    }

    public void EvidenceCollected()
    {
        totalEvidenceCollected++;
    }
}
