using UnityEngine;

public class GameOverDatabase : MonoBehaviour
{
    public float[] allImageSizes;
    public Sprite[] allImages;
    public string[] allRankTexts;
    public Color[] allRankColors;

    public void ApplyGameOverSettings(GameOverDatabase any){
        //Dps de linkar com os elementos de UI necessarios
    }

    public string ChooseRandomMessage(){
        string chosen = allMessages[Random.Range(0,allMessages.Length)];
        return chosen;
    }

    public string[] allMessages;

}