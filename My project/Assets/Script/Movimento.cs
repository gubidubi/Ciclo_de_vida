using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidade = 0;
    public float torque = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-Mathf.Sin(Mathf.Deg2Rad * rb.rotation), Mathf.Cos(Mathf.Deg2Rad * rb.rotation)) * velocidade;

        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddTorque(-1*(torque) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddTorque(torque * Time.deltaTime);
        }
    }
}
