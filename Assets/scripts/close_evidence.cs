using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_evidence : MonoBehaviour
{
    public GameObject screen;
    public GameObject evidence;

    public AudioSource page;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                screen.SetActive(false);
                evidence.SetActive(true);
                page.Play();
            }
        }
    }
}
