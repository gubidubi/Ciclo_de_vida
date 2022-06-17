using UnityEngine;

public class GameOverDatabase : MonoBehaviour
{
    public float[] allImageSizes;
    public Sprite[] allImages;
    public string[] allRankTexts;
    public Color[] allRankColors;

    public string ChooseRandomMessage(){
        string chosen = allMessages[Random.Range(0,allMessages.Length)];
        return chosen;
    }

    [TextArea(1,10)]
    public string[] allMessages;

}