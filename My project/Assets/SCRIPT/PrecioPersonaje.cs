using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PrecioPersonaje : MonoBehaviour
{


    [SerializeField]
    GameObject BadGuy;

    [SerializeField]
    GameObject BadGuy2;

    [SerializeField]
    GameObject Lady;

    [SerializeField]
    GameObject GoodGuy;

    [SerializeField]
    GameObject Sheriff;

    [SerializeField]
    TextMeshProUGUI textLabel;
    float saldo;
    public float Badguy;
    public float Badguy2;
    public float lady;
    public float goodGuy;
    public float sheriff;
    [SerializeField]
    TextMeshProUGUI textoSuma;


    // Start is called before the first frame update
    void Start()
    {
 


    }

    // Update is called once per frame
    void Update()
    {
       
        //textoSuma.text = saldo.ToString("000");
        textLabel = GetComponent<TextMeshProUGUI>();
        //ldo = textLabel.ToString();
        saldo = 0f;
        saldo = (sheriff - lady - goodGuy + goodGuy + Badguy);
        

    }


    public void Personaje1()
    {
       Badguy = 500f;
    }

    public void Personaje2()
    {
       Badguy2 = 750f;
    }

    public void Personaje3()

    {
        goodGuy = -50f;
    }


    public void Personaje4()

    {
        lady = -80f;

    }

    public void Personaje5()

    {
        sheriff = -100f;

    }

}
