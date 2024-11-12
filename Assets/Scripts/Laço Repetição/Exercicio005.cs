using UnityEngine;

public class Exercicio005 : MonoBehaviour
{
    [SerializeField] int dificuldade = 0;
    void Start()
    {
        for(int fase = 1; fase <= 6; fase++)
        {
            dificuldade += 5;
            print("Fase: " + fase + "Dificuldade: " + dificuldade);
        }
        
    }

    void Update()
    {
        
    }
}
