using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [HideInInspector]public static GameStateManager instance{get; private set;}
    [HideInInspector]public bool playing = false;
    [HideInInspector]public bool canStartGame = false;
    [HideInInspector]public Color[] colores = new Color[4];
    [HideInInspector]public Color playerColor ;
    
    // Start is called before the first frame update
    void Awake()
    {
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(gameObject);
        }

        for(int i = 0; i<4;i++){
           colores[i] = (new Color( Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
        } 
        playerColor = colores[0];
    }
}
