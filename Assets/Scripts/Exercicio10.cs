using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] string tipoItem;
    void Start()
    {
        switch (tipoItem)
        {
            case "Espada":
                print("Espada coletada");
                break;
            case "Po��o":
                print("Po��o coletada");
                break;

            default:
                Debug.Log("Item desconhecido");
                break;
        }
    }

    void Update()
    {
        
    }
}
