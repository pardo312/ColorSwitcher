using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField, Range(1,10)]private float jumpForce = 1f;
    private Rigidbody2D rb;
    private bool jumping = false;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButtonDown("Jump")){
            jumping=true;
        }
    }
    
    private void FixedUpdate() {
        if(jumping){
            playerJump();
            jumping = false;
        }
    }
    private void playerJump(){
        if(GameStateManager.instance.canStartGame)
            beginToPlay();
        rb.velocity = new Vector2(0,jumpForce);
    }
    private void beginToPlay(){
        GameStateManager.instance.playing = true;
        GameStateManager.instance.canStartGame = false;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

}
