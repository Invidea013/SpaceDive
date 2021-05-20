using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJPipesManager : MonoBehaviour
{
    public GameObject mjCodeCanvas;

    public void QuitTask()
    {
        mjCodeCanvas.SetActive(false);
    }
}
