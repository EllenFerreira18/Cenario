using System;
using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    [SerializeField] string escolha;
    void Start()
    {
        switch (escolha)
        {
            case "Guerreiro":
                print("Gurreiro escolhido");
                break;

            case "Mago":
                print("Mago escolhido");
                break;

            default:
                print("Inválido");
                break;

          
        }

    }

    void Update()
    {
        
    }
}
