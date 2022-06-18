using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraVida : MonoBehaviour
{
    private float vida;
    public GameObject jogador;
    private float yMax;
    public Vector3 scaleInicial;
    private float vidaMax;
    // Start is called before the first frame update
    void Start()
    {
        yMax = scaleInicial.y;
        scaleInicial = new Vector3(scaleInicial.x, 0, scaleInicial.z);
        vidaMax = jogador.GetComponent<Vida>().vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        vida = jogador.GetComponent<Vida>().vida;
        transform.localScale = scaleInicial + ((yMax * vida/vidaMax) * Vector3.up);
    }
}