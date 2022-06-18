using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraVida : MonoBehaviour
{
    private float vida;
    public GameObject jogador;
    private float yMax;
    public Vector3 scaleInicial;
    public Vector3 scaleBase;
    private float vidaMax;
    private Vida vidaScript;
    // Start is called before the first frame update
    void Start()
    {
        yMax = scaleInicial.y;
        scaleBase = new Vector3(scaleInicial.x, 0, scaleInicial.z);
        vidaScript = jogador.GetComponent<Vida>();
        vidaMax = vidaScript.vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        vida = vidaScript.vida;
        transform.localScale = scaleBase + ((yMax * vida/vidaMax) * Vector3.up);
    }
}