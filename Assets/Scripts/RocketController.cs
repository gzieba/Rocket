using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketController : MonoBehaviour
{
    private Rigidbody r;
    private bool isDead;
    private float currentFuel;
    private LevelController levelController;

    [SerializeField] float thrustForce = 1000.0f;
    [SerializeField] float rotationForce = 250.0f;
    [SerializeField] float initialFuel = 10.0f;

    [SerializeField] Text fuelDisplay;

    [SerializeField] InputController leftButton;
    [SerializeField] InputController rightButton;
    [SerializeField] InputController thrustButton;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        isDead = false;
        currentFuel = initialFuel;
        levelController = new LevelController();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead)
            Movement();

        fuelDisplay.text = currentFuel >= 0.0f ? currentFuel.ToString("F2") : "0,00";
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.Space) || thrustButton.isPressed)
        {
            Debug.Log(currentFuel);
            if(currentFuel > 0.0f)
            {
                r.AddRelativeForce(new Vector3(0.0f, 0.0f, 1.0f) * thrustForce * Time.deltaTime);
                currentFuel -= 1.0f * Time.deltaTime;
            }
        }
        
        r.freezeRotation = true;

        Vector3 rotation = new Vector3(0.0f, 1.0f, 0.0f) * rotationForce * Time.deltaTime;

        if (Input.GetKey(KeyCode.A) || leftButton.isPressed)
        {
            transform.Rotate(-rotation);
        }
        if(Input.GetKey(KeyCode.D) || rightButton.isPressed)
        {
            transform.Rotate(rotation);
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
                isDead = true;
                Invoke("OnWin", 1.0f);
                break;
            default:
                Debug.Log("Dupa");
                isDead = true;
                Invoke("OnDeath", 1.0f);
                break;
        }
    }

    private void OnDeath()
    {
        levelController.ReloadCurrentLevel();
    }

    private void OnWin()
    {
        levelController.NextLevel();
    }

    public float CurrentFuel()
    {
        return currentFuel;
    }
}
