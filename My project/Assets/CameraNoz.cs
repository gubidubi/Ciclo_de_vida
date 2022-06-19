using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNoz : MonoBehaviour
{
    public GameObject jogador;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, jogador.transform.position.y, transform.position.z);
    }
}
