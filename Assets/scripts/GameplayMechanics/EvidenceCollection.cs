using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceCollection : MonoBehaviour
{


    

    public bool EvidencePiece1;
    
    public bool EvidencePiece2;
    /*public bool EvidencePiece3;
    public bool EvidencePiece4;*/


    public GameObject PlaceEvidenceHere1;
    
    public GameObject PlaceEvidenceHere2;
    /*public GameObject PlaceEvidenceHere3;
    public GameObject PlaceEvidenceHere4;*/


    public GameObject TellTruthAboutIt1;
    
    public GameObject TellTruthAboutIt2;
    /*public GameObject TellTruthAboutIt3;
    public GameObject TellTruthAboutIt4;*/




    // Start is called before the first frame update
    void Start()
    {

        EvidencePiece1 = false;
        
        EvidencePiece2 = false;
        /*EvidencePiece3 = false;
        EvidencePiece4 = false;*/

        TellTruthAboutIt1.SetActive(false);
        
        TellTruthAboutIt2.SetActive(false);
        /*TellTruthAboutIt3.SetActive(false);
        TellTruthAboutIt4.SetActive(false);*/



    }


    private void OnMouseOver()
    {

        if (Input.GetKey(KeyCode.Mouse0) && !EvidencePiece1)
        {

            PlaceEvidenceHere1.SetActive(false);
            TellTruthAboutIt1.SetActive(true);
            EvidencePiece1 = true;
            Debug.Log("Evidence 1 has been clicked");

        }


        if (Input.GetKey(KeyCode.Mouse0) && !EvidencePiece2)
        {

            PlaceEvidenceHere2.SetActive(false);
            TellTruthAboutIt2.SetActive(true);
            EvidencePiece2 = true;
            Debug.Log("Evidence 2 has been clicked");

        }


        /*if (Input.GetKey(KeyCode.Mouse0) && !EvidencePiece3)
        {

            PlaceEvidenceHere3.SetActive(false);
            TellTruthAboutIt3.SetActive(true);
            EvidencePiece3 = true;
            Debug.Log("Evidence 3 has been clicked");

        }


        if (Input.GetKey(KeyCode.Mouse0) && !EvidencePiece4)
        {

            PlaceEvidenceHere4.SetActive(false);
            TellTruthAboutIt4.SetActive(true);
            EvidencePiece4 = true;
            Debug.Log("Evidence 4 has been clicked");

        }*/

    }


}
