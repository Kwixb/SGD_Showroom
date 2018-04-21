using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopUp : MonoBehaviour
{
    public GameObject informationPopUp;

    private void Start()
    {
        informationPopUp.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            informationPopUp.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" )
        {
                informationPopUp.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        informationPopUp.SetActive(false);
    }


}
