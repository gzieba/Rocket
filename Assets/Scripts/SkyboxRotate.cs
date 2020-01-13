using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    [SerializeField] Vector3 increment = new Vector3(-1.0f, 1.0f, 1.0f);

    Skybox skybox;

    // Start is called before the first frame update
    void Start()
    {
        skybox = GetComponent<Skybox>();
    }

    // Update is called once per frame
    void Update()
    {
        skybox.transform.Rotate(increment);
    }
}
