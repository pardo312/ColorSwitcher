using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePiecesLogic : MonoBehaviour
{
    [HideInInspector]public Color pieceColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(asignColor());
    }
    IEnumerator asignColor(){
        yield return new WaitForSeconds(0.001f);
        GetComponent<SpriteRenderer>().color = pieceColor;
    }

}
