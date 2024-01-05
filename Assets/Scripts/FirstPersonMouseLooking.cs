using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMouseLooking : MonoBehaviour
{
    public float mouseSens = 15f;

    public Transform playerBody;
    public float xRot;
    public float mousex, mousey;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousex = Input.GetAxis("Mouse X") * mouseSens;
        mousey = Input.GetAxis("Mouse Y") * mouseSens;

        xRot -= mousey;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.Rotate(Vector3.up, mousex);
    }
}
