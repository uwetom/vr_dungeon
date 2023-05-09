using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeCanvasController : MonoBehaviour
{
    public GameObject canvas;

    public void CloseCanvas()
    {
        canvas.SetActive(false);
    }
}
