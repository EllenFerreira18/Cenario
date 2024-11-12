using UnityEngine;

public class Exercicio003 : MonoBehaviour
{
    [SerializeField] int moedas = 0;
    void Start()
    {
        for (int fase = 1; fase <= 10; fase++)
        {
            moedas += 3;

            print("A quantidade de moedas é: " + moedas);
        }
        print("O total de moedas é: " + moedas);
            
    }
    


void Update()
    {
        
    }
}
