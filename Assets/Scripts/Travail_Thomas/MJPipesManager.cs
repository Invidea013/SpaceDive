using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJPipesManager : MonoBehaviour
{
    public GameObject mjCodeCanvas;
    public GameObject freezPanel;
    public GameObject generator;

    public bool taskDone = false;

    private void Update()
    {
        if (generator.GetComponent<MJPipes>().isPowered == true)
        {
            taskDone = true;
            freezPanel.SetActive(true);
            StartCoroutine(TaskIsDone());
        }
    }
    public void QuitTask()
    {
        mjCodeCanvas.SetActive(false);
    }

    IEnumerator TaskIsDone()
    {
        yield return new WaitForSeconds(2);
        QuitTask();
    }
}
