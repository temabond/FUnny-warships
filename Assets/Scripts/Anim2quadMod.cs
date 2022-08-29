using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim2quadMod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            GetComponent<Animator>().SetBool("2_quadMod", true);
        }

    }
}
