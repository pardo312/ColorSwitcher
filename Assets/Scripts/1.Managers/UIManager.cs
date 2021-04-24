using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Views")]
    [SerializeField]UIScoreView scoreView;


    [Header("Screens")]
    [SerializeField]GameObject mainMenuGO;
    [SerializeField]GameObject UIGameplayGO;

    public void Init(){
        
    }
    
    public void UpdateScoreUI(int score){
        scoreView.UpdateScoreText(score);
    }

    public void GoToMainMenu(){
        mainMenuGO.SetActive(true);
        UIGameplayGO.SetActive(false);
    }


    public void Play(){
        mainMenuGO.SetActive(false);
        UIGameplayGO.SetActive(true);
    }
}
