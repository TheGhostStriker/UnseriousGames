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
    public bool IsTruthButtonActive = false;

    //public Button truthButton;

    public void Start()
    {
        TruthButton.SetActive(false);
    }

    public void Update()
    {
        if(!tellTruthButton && !IsTruthButtonActive)
        {
            if (totalEvidenceCollected >= EvidenceAmountInScene)
            {
                TruthButton.SetActive(true);

                IsTruthButtonActive = true;

                Debug.Log("I have been collected??????");
            }
        }

        

    }

    public void EvidenceCollected()
    {
        

        totalEvidenceCollected++;
    }
}
