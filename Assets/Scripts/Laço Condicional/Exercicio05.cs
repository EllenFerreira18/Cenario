using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    [SerializeField] int pontos;
    void Start()
    {
        if (pontos > 50) 
        {
            print("Missão bem-sucedida");
        }
        else{
            print("Missão incompleta");
        }
    }

    void Update()
    {
        
    }
}
