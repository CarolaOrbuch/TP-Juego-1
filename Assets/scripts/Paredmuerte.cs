using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredmuerte : MonoBehaviour
{

    public GameObject cubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("jhrbf");

        if (col.gameObject.tag == "Player")
        {
            Destroy(cubo);
        }
    }
}
