using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BUTTONINICIO : MonoBehaviour
{
    [SerializeField]
    GameObject CanvasFinal;
    [SerializeField]
    GameObject empezar;
    [SerializeField]
    GameObject CanvasPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
     public void EmpezarPartida()
     {
        empezar.SetActive(false);
        CanvasPersonaje.SetActive(false);
    }
    public void Canvasfinal()
    {
        CanvasFinal.SetActive(false);

    }



}
