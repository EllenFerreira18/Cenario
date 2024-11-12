using UnityEngine;

public class Exercicio004 : MonoBehaviour
{
    [SerializeField] int pontuacao = 0;
    void Start()
    {
        for(int combo = 1; combo <= 7; combo++)
        {
            pontuacao += 10;
        }

        print("Pontuação total: " +  pontuacao);
        
    }

    void Update()
    {
        
    }
}
