using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    public GameObject cameraPrincipal;
    private Vida vida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraPrincipal.transform.position.y - transform.position.y > 24) {
            transform.position = transform.position + (Vector3.up * (34 + Random.Range(0, 8)));
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player") {
            vida = collider.gameObject.GetComponent<Vida>();
            vida.luz = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player") {
            vida = collider.gameObject.GetComponent<Vida>();
            vida.luz = false;
        }
    }
}
