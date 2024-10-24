using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Tempo : MonoBehaviour
{
      [SerializeField]
      GameObject start;
     [SerializeField]
     TextMeshProUGUI textoDescuento;

     private string currentTime;
     float tiempoDePartida;
    public TimeSpan remainingTime;


    public float contador = 60f;
    public int saldo = 000;





    // Start is called before the first frame update
    void Start()
    {

        textoDescuento.text = saldo.ToString("00");
        textoDescuento.text = contador.ToString();

     //   saldo = 60f;
       // textoDescuento.text = saldo.ToString();



        //textSaldo.text = saldo.Tostring("00");
        //tiempo.text = contador.Tostring 


    }

    // Update is called once per frame
    void Update()
    {

         if (start == false)
         {

            contador -= Time.deltaTime; 
            contador += saldo + Time.deltaTime;

            tiempoDePartida = -60f;
             tiempoDePartida = tiempoDePartida * Time.deltaTime;
             currentTime = Time.time.ToString("00");


         }

          else
          {
             tiempoDePartida = 0f;



          }



    }
          



     

}
