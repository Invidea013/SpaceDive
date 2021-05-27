using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJCodeLED : MonoBehaviour
{
    public GameObject ledImage;



    public GameObject codeNum;
    public GameObject codeAlpha;

    public bool isTrue = false;

    void Start()
    {
        ledImage.SetActive(false);
        isTrue = false;
    }

    void Update()
    {
        if(codeNum.GetComponent<MJCodeAlpha>().isTrue == true && codeAlpha.GetComponent<MJCodeAlpha>().isTrue == true)
        {
            ledImage.SetActive(true);
            isTrue = true;

        }
        else 
        {
            ledImage.SetActive(false);
            isTrue = false;
        }
    }

}
