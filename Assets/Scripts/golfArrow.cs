using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfArrow : MonoBehaviour
{
    public Rigidbody golfBall;
    public LineRenderer line;



    private void Update()
    {
       transform.position = golfBall.position;
        if (Input.GetButton("Fire1") || Input.GetButton("Jump"))
        {
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position);
            line.SetPosition(1, transform.position + transform.forward * 4f);
        }

        if (Input.GetButtonUp("Fire1") || Input.GetButtonUp("Jump"))
        {
            line.gameObject.SetActive(false);
        }
    }
}
