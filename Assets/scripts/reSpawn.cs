using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reSpawn : MonoBehaviour
{
    Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = new Vector3(16.98f, 0.5f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "Barrera")
        {
            transform.position = spawn;
        }
        else if (col.gameObject.tag == "Pinche")
        {
            transform.position = spawn;
        }
        else if (col.gameObject.tag == "Paredes")
        {
            transform.position = spawn;
        }
    }
}
