using UnityEngine;

public class Exercicio007 : MonoBehaviour
{
    int[] numeros = { 3, 5, 35, 76, 23, 65, 565, 232, 65, 1 };
    int maior = 0;
    void Start()
    {
        maior = numeros[0]; 

        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior número é: " + maior);
        
    }

    void Update()
    {
        
    }
}
