using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem p;
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<ParticleSystem>();
        p.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            p.Play();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            p.Stop();
        }
    }
}
