using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJCodeAlpha : MonoBehaviour
{
    public string[] codeListAlpha = { "A", "B", "C", "D", "E", "F" };

    public AudioSource buttonClickSource;
    public AudioClip[] buttonClick;

    public int listPos = 0;

    public GameObject codeText;

    public int goodNum;
    public bool isTrue = false;

    void Start()
    {
        codeText.GetComponent<UnityEngine.UI.Text>().text = codeListAlpha[listPos];
    }

    private void Update()
    {
        IsGoodNumber();
    }

    public void OnGoUp()
    {
        buttonClickSource.PlayOneShot(buttonClick[0]);

        if (listPos <= 4)
        {
            listPos += 1;
        }
        else
        {
            listPos = 0;
        }
        codeText.GetComponent<UnityEngine.UI.Text>().text = codeListAlpha[listPos];
    }

    public void OnGoDown()
    {
        buttonClickSource.PlayOneShot(buttonClick[0]);

        if (listPos >= 1)
        {
            listPos -= 1;
        }
        else
        {
            listPos = 5;
        }
        codeText.GetComponent<UnityEngine.UI.Text>().text = codeListAlpha[listPos];
    }

    public void IsGoodNumber()
    {
        if (listPos == goodNum)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
    }
}
