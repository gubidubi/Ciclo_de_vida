using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Fim : MonoBehaviour
{
    public TextMeshProUGUI agradecimentos;
    public GameObject Fade;
    public GameObject noz;
    public float k; //pequeno
    public Transform posicaoDaNoz;

    void Start(){
        StartCoroutine(topo());
    }

    private IEnumerator topo(){
        Image imagem = Fade.GetComponent<Image>();
        while (imagem.color.a > 0){
            imagem.color -= new Color(k,k,k,k);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(1f);
        string buffer = "Obrigado por jogar :)";

        foreach (char c in buffer.ToCharArray())
        {
            agradecimentos.text += c;
            yield return new WaitForSeconds(0.2f);
        }

        yield return new WaitForSeconds(5f);
        //Agora a noz cai
        GameObject novaNoz = Instantiate(noz, posicaoDaNoz.position, Quaternion.identity);
        while (novaNoz.transform.position.y > -10){
            yield return new WaitForSeconds(0.5f);
        }

        //Volta com o Fade
        while (imagem.color.a < 1){
            imagem.color += new Color(3*k,3*k,3*k,3*k);
            yield return new WaitForSeconds(0.1f);
        }
        SceneManager.LoadScene("Nut");
    }
}
