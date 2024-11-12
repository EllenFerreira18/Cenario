using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoVida;
    void Start()
    {
        if(pocaoVida == true)
        {
            print("Usando Poção de Vida");
        }
        else if(pocaoVida == false) 
        {
            print("Poção indisponível");
        }
    }

    void Update()
    {
        
    }
}
