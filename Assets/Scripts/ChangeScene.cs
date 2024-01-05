using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChangeScene : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "flag")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Invoke("Level2",1.3f);   
        }

        if(collision.transform.tag == "flag2")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Invoke("Level3",1.3f);
            
        }

        if(collision.transform.tag == "flag3")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Invoke("menu", 1.3f);
        }
    }

    void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    void menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
