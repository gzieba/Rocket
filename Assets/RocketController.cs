using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody r;

    [SerializeField] float thrustForce = 250.0f;
    [SerializeField] float rotationForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            r.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
        }

        r.freezeRotation = true;

        Vector3 rotation = Vector3.forward * rotationForce * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(rotation);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-rotation);
        }

        r.freezeRotation = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "StartPlane":
                break;
            case "FinishPlane":
                Debug.Log("Koniec");
                break;
            default:
                Debug.Log("Dupa");
                break;
        }
    }
}
