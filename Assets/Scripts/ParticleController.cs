using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem p;

    private bool isPlaying = false;

    [SerializeField] InputController thrustButton;

    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<ParticleSystem>();
        p.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || thrustButton.isPressed)
        {
            if(!isPlaying)
            {
                p.Play();
                isPlaying = true;
            }
        }
        if(Input.GetKeyUp(KeyCode.Space) || !thrustButton.isPressed)
        {
            if(isPlaying)
            {
                p.Stop();
                isPlaying = false;
            }
        }
    }
}
