using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forca = 0;
    public float torque = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.up * forca * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddTorque(-1*(torque) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddTorque(torque * Time.deltaTime);
        }
    }
}
