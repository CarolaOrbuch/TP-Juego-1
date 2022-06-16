using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fin : MonoBehaviour
{
    public GameObject canvas;
    public GameObject movimiento;
    public GameObject confetti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            canvas.SetActive(true);
            //Time.timeScale = 0f;
           // movimiento.SetActive(false);
            for (int i = 0; i <= 50; i++)
            {
                // Instantiate(confetti, new Vector3(-76.42f, 1.42f, -5.9f), Quaternion.identity);
                Instantiate(confetti, new Vector3(-76.42f, 1.42f, -5.9f), Quaternion.identity);
                Destroy(confetti, 2);
            }
        }
       
    }
}
