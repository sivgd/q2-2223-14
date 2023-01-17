using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRoller : MonoBehaviour
{
    private static int nscreen = 3;
    private GameObject[] creditScenes = new GameObject[nscreen];
    private static int swapCount;

    // Start is called before the first frame update
    void Start()
    {
        //For each credit scene, add a reference here:
        creditScenes[0] = GameObject.Find("Credit1");
        creditScenes[1] = GameObject.Find("Credit2");
        creditScenes[2] = GameObject.Find("Credit3");
        //creditScenes[3] = GameObject.Find("Credit4");

        //Turn all scenes off
        for (int i = 0; i < nscreen; i++)
        {
            creditScenes[i].SetActive(false);
        }
        //Turn back on the "0th"
        creditScenes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int CurrentScene = swapCount % nscreen;
            creditScenes[CurrentScene].SetActive(false);
            swapCount++;
            CurrentScene = swapCount % nscreen;
            creditScenes[CurrentScene].SetActive(true);
            Debug.Log(CurrentScene);
        }
    }
}
