using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsTracker : MonoBehaviour
{

    public int TruthTold;
    public int LieTold;
    public int SensationTold;



    private void Start()
    {
        TruthTold = 0;
        LieTold = 0;
        SensationTold = 0;
    }

    public void TruthTeller()
    {
        TruthTold++;
    }

    public void LieTeller()
    {
        LieTold++;
    }

    public void SensationTeller()
    {
        SensationTold++;
    }





}
