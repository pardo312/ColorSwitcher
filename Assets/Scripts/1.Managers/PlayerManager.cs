using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManager : MonoBehaviour {
    
    private Rigidbody2D rb;
    public void Init() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void BeginToPlay(){
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void Jump(float jumpForce){
        rb.velocity = new Vector2(0,jumpForce);
    }

    public void GameLost(){
        transform.position = new Vector3(0,-1,0);
        transform.position = new Vector3(0,0,0);

        rb.bodyType = RigidbodyType2D.Static;
    }
}