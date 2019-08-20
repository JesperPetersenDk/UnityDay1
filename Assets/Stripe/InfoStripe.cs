using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoStripe : MonoBehaviour
{
    public GameObject myPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        //1:
        //print("Hello world");

    }

    // Update is called once per frame
    void Update()
    {
        RespectInfo();

    }

    public void OnClickButton1()
    {
        print("Hello World - Opgave 3");
    }

    public void OnRandomClick1()
    {

        for (int i = 0; i < 200; i++)
        {
            Instantiate(myPrefab, new Vector3(249, 127, -60), Quaternion.identity);
        }
        

        print("hej");
    }

    public void RespectInfo()
    {
        var Respect = Input.GetKeyDown(KeyCode.F);
        if(Respect)
        {
            print("Respect");
        }
    }


}
