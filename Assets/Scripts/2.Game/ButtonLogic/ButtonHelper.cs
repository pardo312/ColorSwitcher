using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    
    public void Play(){
        transform.parent.gameObject.SetActive(false);
        GameStateManager.instance.canStartGame = true;
    }
    public void Quit(){
        Application.Quit();
    }
}
