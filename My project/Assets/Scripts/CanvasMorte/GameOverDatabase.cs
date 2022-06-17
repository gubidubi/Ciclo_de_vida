using UnityEngine;

public class GameOverDatabase : MonoBehaviour
{
    public float imageSize;
    public Sprite image;
    public string rankText;
    public Color rankColor;
    public string message;
    public GameOverDatabase(float a, Sprite b, string c, Color d, string e){
        imageSize=a;
        image=b;
        rankText=c;
        rankColor=d;
        message=e;
    }

    public void ApplyGameOverSettings(GameOverDatabase any){
        //Dps de linkar com os elementos de UI necessarios
    }

    public string ChooseRandomMessage(){
        string chosen = allMessages[Random.Range(0,allMessages.Length)];
        return chosen;
    }

    public string[] allMessages;
}