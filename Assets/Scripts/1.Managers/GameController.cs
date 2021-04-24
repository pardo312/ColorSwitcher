using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector]public static GameController instance{get; private set;}

    // Managers
    [SerializeField] public UIManager uiManager;
    [SerializeField] public GameStateManager gameStateManager;
    [SerializeField] public PlayerManager playerManager;

    void Awake()
    {
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(gameObject);
        }

    }
    private void Start() {
        gameStateManager.Init();
        uiManager.Init();
        playerManager.Init();
    }
    
    #region Gameplay
    
    public void PlayerJump(float jumpForce){
        BeginToPlay();
        playerManager.Jump(jumpForce);
    }
    private void BeginToPlay(){
        if(gameStateManager.canStartGame){
            playerManager.BeginToPlay();
            gameStateManager.BeginToPlay();
        }
    }

    public void UpdateScoreAdd(){
        int newScore = gameStateManager.UpdateScore(playerManager.transform.position.y);
        uiManager.UpdateScoreUI(newScore);
    }

    public void LostGame(){
        playerManager.GameLost();
        uiManager.GoToMainMenu();
        gameStateManager.LostGame();
    }

    #endregion

    #region Button Helpers

    public void Play(){
        uiManager.Play();
        gameStateManager.canStartGame = true;
    }

    public void Quit(){
        Application.Quit();
    }

    #endregion


}
