using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoVida;
    void Start()
    {
        if(pocaoVida == true)
        {
            print("Usando Po��o de Vida");
        }
        else if(pocaoVida == false) 
        {
            print("Po��o indispon�vel");
        }
    }

    void Update()
    {
        
    }
}
