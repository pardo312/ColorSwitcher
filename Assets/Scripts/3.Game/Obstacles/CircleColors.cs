using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleColors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> intAlredyPickedColors = new List<int>();
        foreach (Transform child in transform)
        {
            //Pick color
            int colorNumber = Random.Range(0, 4);
            while(intAlredyPickedColors.Contains(colorNumber)){
                colorNumber= Random.Range(0, 4);
            }
            intAlredyPickedColors.Add(colorNumber);
            //Paint Piece Color
            Color childNewColor = GameController.instance.gameStateManager.colores[colorNumber];
            //Asign color to script
            child.GetComponent<CirclePiecesLogic>().pieceColor = GameController.instance.gameStateManager.colores[colorNumber];
        }
    }

}
