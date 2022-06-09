using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBarrera : MonoBehaviour
{
    bool xd = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(xd == true)
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        else
        {
            transform.position -= new Vector3(0, 0, 0.1f);
        }
        if (transform.position.z > 10.7f)
        {
            xd = false;
        }
        if (transform.position.z < -10.7f )
        {
            xd = true;
        }
        
    }
}
