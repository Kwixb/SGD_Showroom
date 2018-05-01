using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey("Escape"))
            {
                Application.Quit();
            }
            else
            {

            }
        }
        else
        {

        }
    }
}

