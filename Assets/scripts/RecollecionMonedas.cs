using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecollecionMonedas : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject, 0.5f);
            audio.Play();
        }
    }
}
