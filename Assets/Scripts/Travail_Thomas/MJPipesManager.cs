using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJPipesManager : MonoBehaviour
{
    public GameObject mjCodeCanvas;
    public GameObject freezPanel;
    public GameObject generator;

    public PlayerManager playerManager;
    public CameraControls cameraControls;

    public bool taskDone = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        playerManager.enabled = false;
        cameraControls.enabled = false;

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
        playerManager.enabled = true;
        cameraControls.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    IEnumerator TaskIsDone()
    {
        yield return new WaitForSeconds(2);
        playerManager.enabled = true;
        cameraControls.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        QuitTask();
    }
}
