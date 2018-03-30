using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovie : MonoBehaviour
{

    void Update ()
    {
		if(Input.GetKeyUp(KeyCode.Space))
        {
            Renderer r = GetComponent<Renderer>();
            MovieTexture movie = (MovieTexture)r.material.mainTexture;
            movie.loop = true;

            if (movie.isPlaying)
            {
                movie.Pause();
            }
            else
            {
                movie.Play();
            }
        }
        

    }
}
