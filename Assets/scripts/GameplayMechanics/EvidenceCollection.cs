using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceCollection : MonoBehaviour
{


    

    public bool EvidencePiece1;
    
    public GameObject PlaceEvidenceHere1;
    
    EvidenceCounter EC;
    public GameObject ObjectThatHoldsEvidenceCounter;




    // Start is called before the first frame update
    void Start()
    {

        EvidencePiece1 = false;
        
        EC = ObjectThatHoldsEvidenceCounter.GetComponent<EvidenceCounter>();

    }


    private void OnMouseOver()
    {

        if (Input.GetKey(KeyCode.Mouse0) && !EvidencePiece1)
        {

            //PlaceEvidenceHere1.SetActive(false);

            EC.EvidenceCollected();
            EvidencePiece1 = true;
            Debug.Log("Evidence 1 has been clicked");

        }


        

    }


}
