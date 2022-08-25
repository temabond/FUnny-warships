using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMode_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetBool("BoolMode_3", true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Animator>().SetBool("BoolMode_3", false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Animator>().SetInteger("IntMode_3", 1);
        }
    }
}
