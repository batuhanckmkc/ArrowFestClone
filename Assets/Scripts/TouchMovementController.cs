using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TouchMovementController : GarbageCollector
{
    public GameObject holdAndMovePopUp;
    protected static float cameraSpeed;
    protected Rigidbody cameraMove;

    private void Start()
    {
        cameraSpeed = 0;
        garbageCollectorSpeed = 0;
        cameraMove = GetComponent<Rigidbody>();
        holdAndMovePopUp.SetActive(true);
    }
    void Update()
    {
        isTouching();
    }
    
   private void FixedUpdate()
    {
        cameraMove.velocity = (Vector3.forward * Time.deltaTime * -cameraSpeed);
    }
 
    public void isTouching()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if (finger.phase == TouchPhase.Moved)
            {
                holdAndMovePopUp.SetActive(false);
                cameraSpeed = 200;
                garbageCollectorSpeed = 200;
            }
        }
    }
}
