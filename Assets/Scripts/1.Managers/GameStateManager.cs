using UnityEngine;

public class GameStateManager : MonoBehaviour {

    [HideInInspector]public bool playing = false;
    [HideInInspector]public bool canStartGame = false;
    [HideInInspector]public Color[] colores = new Color[4];
    [HideInInspector]public Color playerColor ;

    [Header("Score")]
    [HideInInspector]public int score = 0;
    [HideInInspector]public float maxPosY = 0;
    [SerializeField, Range(0,100)] private int scoreMultiplier;

    public void Init(){
        for(int i = 0; i<4;i++){
           colores[i] = (new Color( Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
        } 

        playerColor = colores[0];
    }

    public int UpdateScore(float posY){
        if(posY>maxPosY){
            maxPosY = posY;
            int newScore = (int) (posY * scoreMultiplier);
            score = newScore;
        }
        return score;
    }
    public void BeginToPlay(){
        playing = true;
        canStartGame = false;
    }

    public void LostGame(){
        playing = false;
        canStartGame = false;
        score = 0;
        maxPosY = 0;
    }
}