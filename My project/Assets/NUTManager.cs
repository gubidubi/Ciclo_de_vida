using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NUTManager : MonoBehaviour
{
    public GameObject nut;
    private bool stop = false;
    public GameObject painel;
    public float k;

    void Start(){
        StartCoroutine(Iniciar());
    }
    void Update(){
        if (nut.transform.position.y < 0 && !stop){
            stop = true;
            StartCoroutine(Finalizar());
        }
    }

    private IEnumerator Finalizar(){
        Image imagem = painel.GetComponent<Image>();
        yield return new WaitForSeconds(3f);
        
        while (imagem.color.a < 1){
            imagem.color += new Color(k,k,k,k);
            yield return new WaitForSeconds(0.1f);
        }
        SceneManager.LoadScene("Main"); //CENA INICIAL
    }

    private IEnumerator Iniciar(){
        Image imagem = painel.GetComponent<Image>();
        while (imagem.color.a > 0){
            imagem.color -= new Color(4*k,4*k,4*k,4*k);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
