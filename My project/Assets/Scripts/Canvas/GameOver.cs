using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image imagem;
    public TextMeshProUGUI mensagem;
    public TextMeshProUGUI rank;
    public TextMeshProUGUI pontostxt;
    public TextMeshProUGUI uselessRanktxt;
    public TextMeshProUGUI uselesPointtxt;
    public GameObject botaoVerde;
    public GameObject botaoVermelho;
    private float tamanho;
    

    [Space]
    [Header("Threshold")]
    public long[] rankThreshold;

    [Space]
    [Header("Others")]
    public GameOverDatabase database;


    public void OnDeath(int pontuacao){ //rodar se o jogador morrer

        //Rodar uma animação de aparecer a tela de game over

        imagem.GetComponent<RectTransform>().localScale = new Vector3(tamanho,tamanho,1f); //Reseta o tamanho da imagem
        int pontos=pontuacao; //pontos vem aqui
        int i;
        for (i = 0; i < 4; i++){
            if (pontos < rankThreshold[i]){
                if (i > 0 && pontos >= rankThreshold[i-1]){ //casos B,A,S
                    imagem.sprite = database.allImages[i];
                    tamanho = database.allImageSizes[i];
                    imagem.GetComponent<RectTransform>().localScale = new Vector3(tamanho,tamanho,1f);
                    mensagem.text = database.ChooseRandomMessage();
                    rank.text = database.allRankTexts[i];
                    rank.color = database.allRankColors[i];
                    pontostxt.text = pontos.ToString();
                    break;

                }
                else{ //caso C
                    imagem.sprite = database.allImages[0];
                    tamanho = database.allImageSizes[0];
                    imagem.GetComponent<RectTransform>().localScale = new Vector3(tamanho,tamanho,1f);
                    mensagem.text = database.ChooseRandomMessage();
                    rank.text = database.allRankTexts[0];
                    rank.color = database.allRankColors[0];
                    pontostxt.text = pontos.ToString();
                    break;
                }
            }
        }
        StartCoroutine(GameOverSequence());
    }

    private IEnumerator GameOverSequence(){
        HideComponents();
        //Bring down the panel
        yield return new WaitForSeconds(1);
        database.allSounds[0].Play();
        // 1 - mostrar pontuação - FEITO
        uselesPointtxt.enabled = true;
        uselesPointtxt.gameObject.GetComponent<Animator>().SetTrigger("cair");
        yield return new WaitForSeconds(1);
        database.allSounds[0].Play();
        pontostxt.enabled = true;
        pontostxt.gameObject.GetComponent<Animator>().SetTrigger("cair");
        
        // 2 - mostrar rank
        yield return new WaitForSeconds(1);
        database.allSounds[0].Play();
        uselessRanktxt.enabled = true;
        uselessRanktxt.gameObject.GetComponent<Animator>().SetTrigger("cair");
        yield return new WaitForSeconds(1.5f);
        database.allSounds[0].Play();
        rank.enabled =  true;
        rank.gameObject.GetComponent<Animator>().SetTrigger("cair");
        yield return new WaitForSeconds(1);
        database.allSounds[0].Play();
        // 3 - mostrar imagem
        imagem.enabled=true;
        imagem.gameObject.GetComponent<Animator>().SetTrigger("cair");
        yield return new WaitForSeconds(1);
        // 4 - mostrar mensagem
        mensagem.gameObject.GetComponent<Animator>().SetTrigger("aparecer");
        mensagem.enabled = true;
        yield return new WaitForSeconds(2);
        botaoVermelho.SetActive(true);
        botaoVerde.SetActive(true);

    }

    public void HideComponents(){
        mensagem.enabled = false;
        imagem.enabled = false;
        rank.enabled = false;
        pontostxt.enabled = false;
        uselessRanktxt.enabled = false;
        uselesPointtxt.enabled = false;
        botaoVermelho.SetActive(false);
        botaoVerde.SetActive(false);
    }
}
