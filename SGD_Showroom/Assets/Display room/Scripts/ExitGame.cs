using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Escape))
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

    //void Update()
    //{
    //    if (Input.GetKeyUp(KeyCode.Escape))
    //    {
    //        Application.Quit();
    //    }
    //    else
    //    {

    //    }
    //}
}

