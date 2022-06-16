using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimientoBola : MonoBehaviour
{
    float speed = 0.1f;
    int rotation = 3;
    public Text Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotation, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotation, 0);
        }

        Tiempo.text = Time.time.ToString("0.00");
    }
}
