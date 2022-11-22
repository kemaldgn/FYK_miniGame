using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    float counter = 0;

    private void OnMouseOver() {
        DrawMesh.canDraw = true;
        this.gameObject.SetActive(false);
        drawController.checkedPoints++;
        print(drawController.checkedPoints);
    }
    
}
