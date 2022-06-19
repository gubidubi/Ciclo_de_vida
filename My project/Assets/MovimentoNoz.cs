using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoNoz : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forca = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(transform.right * forca * Time.deltaTime);
           
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
             rb.AddForce(-transform.right * forca * Time.deltaTime);
          
        }
    }
}
