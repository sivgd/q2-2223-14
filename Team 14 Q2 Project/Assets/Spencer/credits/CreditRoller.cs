using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRoller : MonoBehaviour
{
    private static int nscreen = 8;
    private GameObject[] creditScenes = new GameObject[nscreen];
    private static int swapCount;

    // Start is called before the first frame update
    void Start()
    {
        //For each credit scene, add a reference here:
        creditScenes[0] = GameObject.Find("Ehron");
        creditScenes[1] = GameObject.Find("Sydney");
        creditScenes[2] = GameObject.Find("Cassie");
        creditScenes[3] = GameObject.Find("Isabella");
        creditScenes[4] = GameObject.Find("Aldo");
        creditScenes[5] = GameObject.Find("Spencer");
        creditScenes[6] = GameObject.Find("Ian");
        creditScenes[7] = GameObject.Find("Dillon");
        //creditScenes[8] = GameObject.Find("Credit9");
        //creditScenes[9] = GameObject.Find("Credit10");

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
        if (Input.anyKeyDown)
        {

           // if (creditScenes[8])
           // {
               // creditScenes[0].SetActive(true);
               // creditScenes[8].SetActive(false);

           // }
            //else
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
}
