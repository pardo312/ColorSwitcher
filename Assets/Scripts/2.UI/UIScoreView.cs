using UnityEngine;
using TMPro;

public class UIScoreView : MonoBehaviour {

    [SerializeField]private TMP_Text scoreText;
    
    public void UpdateScoreText(int newScore){
        scoreText.text = newScore.ToString();
    }
}