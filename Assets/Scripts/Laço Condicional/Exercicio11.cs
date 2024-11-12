using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int estado;
    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Boa tarde! Como vai");
                break;  

            case 2:
                print("Poderia me ajudar");
                break;  

            default:
                print("Nada a dizer sobew isso...");
                break;
        }

    }

    void Update()
    {
        
    }
}
