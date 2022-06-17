using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image imagem;
    public TextMeshProUGUI mensagem;
    public TextMeshProUGUI rank;
    public TextMeshProUGUI pontostxt;
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
    }
}
