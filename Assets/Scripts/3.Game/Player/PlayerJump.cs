using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField, Range(1,10)]private float jumpForce = 1f;
    private bool jumping = false;

    private void Update(){
        if(Input.GetButtonDown("Jump")){
            jumping=true;
        }
        GameController.instance.UpdateScoreAdd();
    }
    
    private void FixedUpdate() {
        if(jumping){
            GameController.instance.PlayerJump(jumpForce);
            jumping = false;
        }
    }

}
