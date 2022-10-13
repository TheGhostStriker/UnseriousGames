using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseNewsTracker : MonoBehaviour
{

    NewsTracker newsTracker;

    private void Start()
    {
        newsTracker = GameObject.FindGameObjectWithTag("NewsTracker").GetComponent<NewsTracker>();
    }


    public void OnTruthTold()
    {
        newsTracker.TruthTeller();
    }

    public void OnLieTold()
    {
        newsTracker.LieTeller();
    }


    public void OnSensationTold()
    {
        newsTracker.SensationTeller();
    }


}
