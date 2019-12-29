using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuRocketMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = position.x + Mathf.Sin(Time.time) * Time.deltaTime;
        position.y = position.y + Mathf.Sin(Time.time) * Time.deltaTime;
        position.z = position.z + Mathf.Sin(Time.time) * Time.deltaTime;
        transform.position = position;
    }
}
