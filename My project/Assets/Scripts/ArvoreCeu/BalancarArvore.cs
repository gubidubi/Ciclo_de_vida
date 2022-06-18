using UnityEngine;

public class BalancarArvore : MonoBehaviour
{
    private float timeCounter = 0;
    public Transform tree;
    public float amplitude; //Maior angulo
    public float velocidade_angular;

    void Update()
    {
        tree.rotation = Quaternion.Euler(0,0, -7.5f + amplitude * Mathf.Sin(velocidade_angular*timeCounter));
        timeCounter += Time.deltaTime;
    }
}
