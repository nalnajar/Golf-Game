using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScript : MonoBehaviour
{
    public AudioSource victory;
    private void OnCollisionEnter(Collision collision)
    {
        
            victory.Play();
        
    }
}
