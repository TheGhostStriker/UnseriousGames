using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvidenceCounter : MonoBehaviour
{
    public int totalEvidenceCollected = 0;

    public bool tellTruthButton = false;

    public Button truthButton;

    private void Update()
    {
        if(tellTruthButton == false)
        {
            if(totalEvidenceCollected >= 3)
            {
                tellTruthButton = true;
            }
        }
    }

    public void EvidenceCollected()
    {
        totalEvidenceCollected++;
    }
}
