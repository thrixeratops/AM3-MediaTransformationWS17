using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalIdle : MonoBehaviour
{

    Vector3 myScale;
    int fwd, freq;
    float rnd, minScale, maxScale, scaleRange;

    // Use this for initialization
    void Start()
    {
        // Custom values
        freq = 60;
        scaleRange = 0.025F;

        // Automatic set values
        myScale = new Vector3(0, (scaleRange / 60F * freq / 60F), 0);
        fwd = 1;
        minScale = 1F - (scaleRange / 2);
        maxScale = 1F + (scaleRange / 2);

        // Randomizing values for a more natural motion
        rnd = Random.Range(minScale, maxScale) - 1F;
        freq += Random.Range(-(freq/10), freq/10);

        // Applying random values
        transform.localScale += new Vector3(0, rnd, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (fwd == 1)
        {
            transform.localScale += myScale;
            if (transform.localScale.y >= maxScale) fwd = 0;
        }
        else
        {
            transform.localScale -= myScale;
            if (transform.localScale.y <= minScale) fwd = 1;
        }
    }
}
