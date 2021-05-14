using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public PlayerManager playerManager;

    public GameObject playerUI;
    public GameObject defeatUI;
    public GameObject fadeOut;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        playerManager.GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerManager.oxBar.value <= 0f)
        {
            playerManager.enabled = false;
            timer += Time.deltaTime;
            fadeOut.SetActive(true);

            if(timer >= 1f)
            {
                playerUI.SetActive(false);
                defeatUI.SetActive(true);
            }

            Destroy(fadeOut, 3f);
        }
    }
}
