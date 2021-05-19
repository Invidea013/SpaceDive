using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManage : MonoBehaviour
{
    public GameObject[] slotList;
    public GameObject[][] slotGrid;

    void Start()
    {
        for (int i = 0; i <= 4; i++)
        {
            for ( int j = 0; j <= 3; j++)
            {
                slotGrid [i][j] = slotList [j*4+i];
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
