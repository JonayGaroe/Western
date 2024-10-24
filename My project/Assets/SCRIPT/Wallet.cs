using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI textoSuma;
  
    [SerializeField]
    Wallet myWallet;

    // Start is called before the first frame update
    void Start()
    {
        textoSuma.text = saldo.ToString("000");


    }

    // Update is called once per frame
    void Update()
    {

        myWallet = GetComponent<Wallet>();
        myWallet.saldo = -saldo;
        saldo = Random.Range(25f, 300f);


    }
}
