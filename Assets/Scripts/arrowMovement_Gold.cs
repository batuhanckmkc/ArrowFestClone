using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class arrowMovement_Gold : TouchMovementController
{
    public static int gold;
    public TextMeshProUGUI goldText;
    private Touch touch;
    Vector3 vec = Vector3.zero;
    private float speedModifier;
    public float minX;
    public float maxX;
    Rigidbody arrowMove;

    void Start()
    {
        goldText.text = PlayerPrefs.GetInt("gold").ToString();
        if (PlayerPrefs.HasKey("gold"))
        {
            gold = PlayerPrefs.GetInt("gold");
        }
        speedModifier = 0.003f;
        arrowMove = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        arrowMove.velocity = (Vector3.forward * Time.deltaTime * -cameraSpeed);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                    //Debug.Log(touch.position);
                    transform.position = new Vector3(transform.position.x - touch.deltaPosition.x * speedModifier, transform.position.y, transform.position.z);
            }   
            //arrowMove.position = new Vector3(Mathf.Clamp(arrowMove.position.x, minX, maxX), 0.0f, 0.0f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ninjaMan")
        {
            gold += 1;
            PlayerPrefs.SetInt("gold", gold);
            goldText.text = gold.ToString();
            //Debug.Log("Gold:" + gold);
        }
        if (other.gameObject.tag == "Walls")
        {
            Destroy(other.gameObject);
        }
    }
}
