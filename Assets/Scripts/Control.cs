using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Control : MonoBehaviour
{

    float xRot, yRot = 0f;

    public Rigidbody golfBall;

    public float rotSpeed = 7f;

    public float shoot = 40f;

    public LineRenderer line;
    // Start is called before the first frame update
    void Start() ////ignore all this, just testings to see how i can get the arrow to work using linerenderer, golfArrow is the implementation of this code.
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = golfBall.position;
        if (Input.GetMouseButton(1))
        {
            xRot += Input.GetAxis("Mouse X") * rotSpeed;
            yRot += Input.GetAxis("Mouse Y") * rotSpeed;
            if(yRot < -40f)
            {
                yRot = -40f;
            }
            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position);
            line.SetPosition(1, transform.position + transform.forward * 4f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            golfBall.velocity = transform.forward * shoot;
            line.gameObject.SetActive(false);
        }
        if (Input.GetMouseButtonUp(1))
        {
            line.gameObject.SetActive(false);
        }
    }
}
