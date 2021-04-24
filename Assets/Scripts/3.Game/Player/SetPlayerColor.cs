using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = GameController.instance.gameStateManager.playerColor;
    }

}
