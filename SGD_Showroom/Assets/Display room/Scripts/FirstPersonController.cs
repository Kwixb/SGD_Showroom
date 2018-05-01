using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public GameObject cam;
    public float speed = 2f, sensitivity = 2f;
    float moveFB, moveLR, rotX, rotY, verticalVelocity;
    CharacterController charCon;
    
    void Start()
    {
        charCon = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        moveFB = Input.GetAxis ("Vertical") * speed;
        moveLR = Input.GetAxis ("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY -= Input.GetAxis("Mouse Y") * sensitivity;

        rotY = Mathf.Clamp(rotY, -60f, 60f);

        Vector3 movement = new Vector3(moveLR, verticalVelocity, moveFB);
        transform.Rotate(0, rotX, 0);
        cam.transform.localRotation = Quaternion.Euler(rotY, 0, 0);

        movement = transform.rotation * movement;
        charCon.Move(movement * Time.deltaTime);
    }

}
