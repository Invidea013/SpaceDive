using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MJPipes : MonoBehaviour
{
    public int idNum;
    Image m_Image;

    public Sprite spriteOn;
    public Sprite spriteOff;

    public GameObject pipeCanvas;

    public GameObject sourceDown;
    public GameObject sourceUp;
    public GameObject sourceLeft;
    public GameObject sourceRight;

    public bool isPowered;

    public int rotationState;


    private void Start()
    {
        m_Image = GetComponent<Image>();
    }
    private void Update()
    {
        if (idNum == 0)
        {
            // can't be powered
        }

        if (idNum == 1)
        {
            // can't be powered
        }

        if (idNum == 2)
        {
            if ((rotationState == 0 || rotationState == 2) && sourceDown.GetComponent<MJPipes>().rotationState == 3 && sourceDown.GetComponent<MJPipes>().isPowered == true)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 3)
        {
            if ((rotationState == 1 || rotationState == 2) && sourceRight.GetComponent<MJPipes>().isPowered == true && sourceRight.GetComponent<MJPipes>().rotationState == 0)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 4)
        {
            if ((rotationState == 0 || rotationState == 1) && sourceDown.GetComponent<MJPipes>().isPowered == true && (sourceDown.GetComponent<MJPipes>().rotationState == 0 || sourceDown.GetComponent<MJPipes>().rotationState == 2))
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 10)
        {
            if ((rotationState == 0 || rotationState == 1) && sourceDown.GetComponent<MJPipes>().isPowered == true)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 11)
        {
            if ((rotationState == 1 || rotationState == 3) && sourceLeft.GetComponent<MJPipes>().isPowered == true && sourceLeft.GetComponent<MJPipes>().rotationState == 1)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 12)
        {
            if ((rotationState == 0 || rotationState == 3) && sourceLeft.GetComponent<MJPipes>().isPowered == true && (sourceLeft.GetComponent<MJPipes>().rotationState == 1 || sourceLeft.GetComponent<MJPipes>().rotationState == 3))
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 13)
        {
            if ( sourceUp.GetComponent<MJPipes>().isPowered == true && sourceUp.GetComponent<MJPipes>().rotationState == 1)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 14)
        {
            if ((rotationState == 0 || rotationState == 2) && sourceDown.GetComponent<MJPipes>().rotationState == 3 && sourceDown.GetComponent<MJPipes>().isPowered == true)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 20)
        {
            if (rotationState == 0 || rotationState == 2)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 21)
        {
            if ((rotationState == 1 || rotationState == 2) && sourceRight.GetComponent<MJPipes>().isPowered == true && sourceRight.GetComponent<MJPipes>().rotationState == 3)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 22)
        {
            if ((rotationState == 2 || rotationState == 3) && sourceUp.GetComponent<MJPipes>().isPowered == true && sourceUp.GetComponent<MJPipes>().rotationState == 0)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 23)
        {
            if (((rotationState == 0 || rotationState == 2) && sourceDown.GetComponent<MJPipes>().rotationState == 3 && sourceDown.GetComponent<MJPipes>().isPowered == true) || (rotationState == 1 || rotationState == 3) && sourceLeft.GetComponent<MJPipes>().isPowered == true && sourceLeft.GetComponent<MJPipes>().rotationState == 2)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 24)
        {
            if ((rotationState == 0 || rotationState == 3) && (sourceLeft.GetComponent<MJPipes>().rotationState == 1 || sourceLeft.GetComponent<MJPipes>().rotationState == 3) && sourceLeft.GetComponent<MJPipes>().isPowered == true )
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 30)
        {

        }

        if (idNum == 31)
        {
            if ((rotationState == 1 || rotationState == 3) || ((rotationState == 0 || rotationState == 2) && sourceUp.GetComponent<MJPipes>().isPowered == true && sourceUp.GetComponent<MJPipes>().rotationState == 1))
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 32)
        {
            if ((rotationState == 1 || rotationState == 3) && sourceLeft.GetComponent<MJPipes>().isPowered == true && (sourceLeft.GetComponent<MJPipes>().rotationState == 1 || sourceLeft.GetComponent<MJPipes>().rotationState == 3))
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 33)
        {
            if (((rotationState == 0 || rotationState == 3) && sourceLeft.GetComponent<MJPipes>().isPowered == true && (sourceLeft.GetComponent<MJPipes>().rotationState == 1 || sourceLeft.GetComponent<MJPipes>().rotationState == 3)) || ((rotationState == 1 || rotationState == 2) && sourceRight.GetComponent<MJPipes>().isPowered == true && sourceLeft.GetComponent<MJPipes>().rotationState == 3))
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (idNum == 34)
        {
            if ((rotationState == 2 || rotationState == 3) && sourceUp.GetComponent<MJPipes>().isPowered == true && sourceUp.GetComponent<MJPipes>().rotationState == 0)
            {
                isPowered = true;
            }
            else
            {
                isPowered = false;
            }
        }

        if (isPowered == true)
        {
            m_Image.sprite = spriteOn;
        }
        else
        {
            m_Image.sprite = spriteOff;
        }
    }

    public void OnPipeRotate()
    {
        if (rotationState >= 3)
        {
            rotationState = -1;
            Debug.Log("Clicked");
        }
        rotationState += 1;

        this.transform.Rotate(0.0f, 0.0f, 90.0f);
    }
}
