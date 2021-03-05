using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 3;
    private float plotSize = 64.5f;
    private float xPosLeft = -2.9f;
    private float xPosRight = 2.9f;
    private float lastZPos = 0f;

    public List<GameObject> leftPlots;
    public List<GameObject> rightPlots;    
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }
    public void SpawnPlot()
    {
        GameObject plotLeft = leftPlots[Random.Range(0, leftPlots.Count)];
        GameObject plotRight = rightPlots[Random.Range(0, rightPlots.Count)];

        float zPos = lastZPos + plotSize;
        Instantiate(plotLeft, new Vector3(xPosLeft, 0.025f, zPos), plotLeft.transform.rotation);
        Instantiate(plotRight, new Vector3(xPosRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;
    }
}
