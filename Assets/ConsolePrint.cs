using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i;
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name + ":" + i);
    }
}
