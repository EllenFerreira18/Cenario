using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    [SerializeField] int pontos;
    void Start()
    {
        if (pontos > 50) 
        {
            print("Miss�o bem-sucedida");
        }
        else{
            print("Miss�o incompleta");
        }
    }

    void Update()
    {
        
    }
}
