using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroductionSequence : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public Animator textFade1;
    public Animator textFade2;
    public Animator textFade3;
    public Animator textFade4;

    public void Start()
    {
        Invoke("FirstTextAppear", 15f);
    }

    public void FirstTextAppear()
    {
        textFade1.SetBool("fadeMe", true);
        Invoke("FadeToSecondText", 7f);
    }

    public void FadeToSecondText()
    {
        textFade1.SetBool("fadeMe", false);
        textFade2.SetBool("fadeMe", true);

        Invoke("FadeToThirdText", 7f);
    }

    public void FadeToThirdText()
    {
        textFade2.SetBool("fadeMe", false);
        textFade3.SetBool("fadeMe", true);

        Invoke("FadeToLastText", 7f);
    }

    public void FadeToLastText()
    {
        textFade3.SetBool("fadeMe", false);
        textFade4.SetBool("fadeMe", true);

        Invoke("ChangeScene", 7f);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
