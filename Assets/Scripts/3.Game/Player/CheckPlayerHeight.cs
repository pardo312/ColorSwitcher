using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CheckPlayerHeight : MonoBehaviour
{    
    private float playerMaxHeight = 1;
    [SerializeField]private CinemachineVirtualCamera virtualCamera;
    [SerializeField]private GameObject canvasMenu;
    private Vector3 startCamPos;
    private Quaternion startCamRot;
    // Start is called before the first frame update
    void Start()
    {
        startCamPos=virtualCamera.transform.position;
        startCamRot = virtualCamera.transform.rotation;
    }

    void Update()
    {
        checkIfLoseGameByTouchOfScreen();
        checkPlayerNewMaxHeight();
    }

    private void checkPlayerNewMaxHeight(){
        if(transform.position.y>playerMaxHeight){
            playerMaxHeight = transform.position.y;
        }
    }

    private void checkIfLoseGameByTouchOfScreen(){
        if(transform.position.y <= playerMaxHeight-7.3f)
            gameLost();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Obstacle"))
            if(!(GameController.instance.gameStateManager.playerColor == other.gameObject.GetComponent<CirclePiecesLogic>().pieceColor))
                gameLost();
    }

    private void gameLost(){
        playerMaxHeight=1;
        GameController.instance.LostGame();
    }
}
