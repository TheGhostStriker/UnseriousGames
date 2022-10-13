using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichNews : MonoBehaviour
{

    NewsTracker newsTracker;
    public GameObject TruthEnding;
    public GameObject LieEnding;
    public GameObject SensationalEnding;

    void Start()
    {
        newsTracker = GameObject.FindGameObjectWithTag("NewsTracker").GetComponent<NewsTracker>();

        TruthEnding.SetActive(false);
        LieEnding.SetActive(false);
        SensationalEnding.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (newsTracker.TruthTold >= 2)
        {
            TruthEnding.SetActive(true);
        }

        if (newsTracker.LieTold >= 2)
        {
            LieEnding.SetActive(true);
        }

        if (newsTracker.SensationTold >= 2)
        {
            SensationalEnding.SetActive(true);  
        }

        if (newsTracker.SensationTold == 1 && newsTracker.LieTold == 1 && newsTracker.TruthTold == 1)
        {
            LieEnding.SetActive(true);
        }


    }
}
