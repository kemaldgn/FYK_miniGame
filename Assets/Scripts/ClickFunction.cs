using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFunction : MonoBehaviour
{
    [SerializeField] DrawMesh DrawMesh;
    private void OnMouseDown() {
        DrawMesh.canDraw = true;
    }
    private void OnMouseExit() {
        DrawMesh.canDraw = false;
    }
}
