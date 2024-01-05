using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastLogic : MonoBehaviour
{
    public float range = 100f;

    public Text showText;
    public Points Stroke;
    public AudioSource hit;
    
    private float force;

    public Camera fps;
    public void Update()
    {
        if (Input.GetButton("Fire1") || Input.GetButton("Jump"))
        {
            force += 5000f * Time.deltaTime;
            showText.text = "Force: " + force;
        }
        if (Input.GetButtonUp("Fire1") || Input.GetButtonUp("Jump"))
        {
            
            RaycastHit hitInfo;
            if (Physics.Raycast(fps.transform.position, fps.transform.forward, out hitInfo, range))
            {

                
                hitInfo.rigidbody.AddForce(transform.forward * force);
                    Stroke.IncreaseScore();
                force = 0f;
                showText.text = "Force: " + force;
                Debug.Log(hitInfo.transform.name);
                hit.Play();
            }
        }
     
    }


}
