using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CheckPlayerHeight : MonoBehaviour
{    
    private float playerMaxHeight = 1;
    private Rigidbody2D rb;
    [SerializeField]private CinemachineVirtualCamera virtualCamera;
    [SerializeField]private GameObject canvasMenu;
    private Vector3 startCamPos;
    private Quaternion startCamRot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startCamPos=virtualCamera.transform.position;
        startCamRot = virtualCamera.transform.rotation;
    }

    // Update is called once per frame
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
            if(!(GameStateManager.instance.playerColor == other.gameObject.GetComponent<CirclePiecesLogic>().pieceColor))
                gameLost();
    }
    private void gameLost(){
        transform.position = new Vector3(0,-1,0);
        transform.position = new Vector3(0,0,0);
        playerMaxHeight=1;
        canvasMenu.SetActive(true);
        rb.bodyType = RigidbodyType2D.Static;
        GameStateManager.instance.playing = false;
        GameStateManager.instance.canStartGame = false;
    }
}
