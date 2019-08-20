using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoStripe : MonoBehaviour
{
    public GameObject myPrefab;
    public float ms;

    // Start is called before the first frame update
    void Start()
    {
        //1:
        //print("Hello world");

        ms = 10F;
    }

    // Update is called once per frame
    void Update()
    {
        RespectInfo();

        //opgave: 7...
        transform.Translate(ms * Input.GetAxis("Horizontal") * Time.deltaTime,
            0F,
            ms * Input.GetAxis("Vertical") * Time.deltaTime);
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
