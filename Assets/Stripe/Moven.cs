using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moven : MonoBehaviour
{

    public float ms;
    // Start is called before the first frame update
    void Start()
    {
        ms = 80F;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(ms * Input.GetAxis("Horizontal") * Time.deltaTime,
            0F,
            ms * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
